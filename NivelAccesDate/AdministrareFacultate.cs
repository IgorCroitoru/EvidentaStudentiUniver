using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace NivelAccesDate
{

    public class FacultateData
    {
        public int? NumberOfGrupe { get; set; }
        public int? NumberOfStudents { get; set; }
        public int? NumberOfSpecialitati { get; set; }
    }
    public class AdministrareFacultate : IStocareFacultate
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool CreateOne(Facultate entity)
        {
            return SqlDBHelper.ExecuteNonQuery("INSERT INTO FACULTATE VALUES (Facultate_seq.NEXTVAL, :Nume , :Abreviere)", CommandType.Text,
                 new OracleParameter(":Nume", OracleDbType.Varchar2, entity.NUME, ParameterDirection.Input),
                new OracleParameter(":Abreviere", OracleDbType.Varchar2, entity.ABREVIERE, ParameterDirection.Input)

                );
        }

        public bool CanBeDeleted(int idFacultate)
        {
            string sql = @"
        SELECT 
            NVL(SUM(sub_st.NUMAR_STUDENTI), 0) AS TOTAL_STUDENTS
        FROM 
            FACULTATE f
        LEFT JOIN (
            SELECT 
                sp.ID_FACULTATE,
                COUNT(s.ID_STUDENT) AS NUMAR_STUDENTI
            FROM
                STUDENTI s
            JOIN 
                SPECIALITATE sp ON s.ID_SPECIALITATE = sp.ID_SPECIALITATE
            GROUP BY 
                sp.ID_FACULTATE
        ) sub_st ON f.ID_FACULTATE = sub_st.ID_FACULTATE
        WHERE
            f.ID_FACULTATE = :IdFacultate
        ";

            var parameters = new List<OracleParameter>();
            parameters.Add(new OracleParameter(":IdFacultate", OracleDbType.Int32) { Value = idFacultate });

            var result = SqlDBHelper.ExecuteNonQuery(sql, CommandType.Text, parameters.ToArray());

            // Convert the result to an integer
            int totalStudents = Convert.ToInt32(result);

            // Return true if the total number of students is zero, false otherwise
            return totalStudents == 0;
        }

        public bool DeleteOne(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("BEGIN " +
                "DELETE FROM GRUPE WHERE ID_SPECIALITATE IN (SELECT ID_SPECIALITATE FROM SPECIALITATE WHERE ID_FACULTATE = :IdFacultate); " +
                "DELETE FROM SPECIALITATE WHERE ID_FACULTATE = :IdFacultate; " +
                "DELETE FROM FACULTATE WHERE ID_FACULTATE = :IdFacultate; " +
                "END",
                CommandType.Text,
                new OracleParameter(":IdFacultate", OracleDbType.Int32,OracleDbType.Int32, ParameterDirection.Input)
                );
        }

        public List<Facultate> GetAll()
        {
            var result = new List<Facultate>();
            var dsFacult = SqlDBHelper.ExecuteDataSet("SELECT * FROM FACULTATE", CommandType.Text);
            foreach (DataRow ds in dsFacult.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Facultate(ds));
            }
            return result;
        }

        public Tuple<List<Facultate>, Dictionary<int, FacultateData>> GetFacultateData()
        {
            string sql = @"
                    SELECT 
                        f.ID_FACULTATE, 
                        f.NUME, 
                        f.ABREVIERE, 
                        NVL(sub_s.NUMAR_SPECIALITATI, 0) AS NUMAR_SPECIALITATI, 
                        NVL(sub_g.NUMAR_GRUPE, 0) AS NUMAR_GRUPE,
                        NVL(sub_st.NUMAR_STUDENTI, 0) AS NUMAR_STUDENTI
                    FROM 
                        FACULTATE f
                    LEFT JOIN (
                        SELECT 
                            sp.ID_FACULTATE,
                            COUNT(sp.ID_SPECIALITATE) AS NUMAR_SPECIALITATI
                        FROM 
                            SPECIALITATE sp
                        GROUP BY 
                            sp.ID_FACULTATE
                    ) sub_s ON f.ID_FACULTATE = sub_s.ID_FACULTATE
                    LEFT JOIN (
                        SELECT 
                            sp.ID_FACULTATE,
                            COUNT(s.ID_STUDENT) AS NUMAR_STUDENTI
                        FROM
                            STUDENTI s
                        JOIN 
                            SPECIALITATE sp ON s.ID_SPECIALITATE = sp.ID_SPECIALITATE
                        GROUP BY 
                            sp.ID_FACULTATE
                    ) sub_st ON f.ID_FACULTATE = sub_st.ID_FACULTATE
                    LEFT JOIN (
                        SELECT 
                            sp.ID_FACULTATE,
                            COUNT(g.ID_GRUPA) AS NUMAR_GRUPE
                        FROM 
                            GRUPE g
                        JOIN 
                            SPECIALITATE sp ON g.ID_SPECIALITATE = sp.ID_SPECIALITATE
                        GROUP BY 
                            sp.ID_FACULTATE
                    ) sub_g ON f.ID_FACULTATE = sub_g.ID_FACULTATE
                    ORDER BY 
                        f.ID_FACULTATE
                    ";

            List<Facultate> facultati = new List<Facultate>();
            Dictionary<int, FacultateData> numbers = new Dictionary<int, FacultateData>();
            var dsResult = SqlDBHelper.ExecuteDataSet(sql, CommandType.Text);
            
            foreach (DataRow dr in dsResult.Tables[PRIMUL_TABEL].Rows)
            {
                FacultateData fd = new FacultateData();
                Facultate f = new Facultate(dr);
                facultati.Add(f);
                if (dr.Table.Columns.Contains("NUMAR_SPECIALITATI"))
                {
                    fd.NumberOfSpecialitati = int.Parse(dr["NUMAR_SPECIALITATI"].ToString());
                    
                }
                if (dr.Table.Columns.Contains("NUMAR_GRUPE"))
                {
                    fd.NumberOfGrupe = int.Parse(dr["NUMAR_GRUPE"].ToString());

                }
                if (dr.Table.Columns.Contains("NUMAR_STUDENTI"))
                {
                    fd.NumberOfStudents = int.Parse(dr["NUMAR_STUDENTI"].ToString());

                }
               
                numbers.Add(f.ID_FACULTATE, fd);

            }


            return Tuple.Create(facultati, numbers);
        }
        public List<string> GetDistinct(string distinct)
        {
            throw new NotImplementedException();
        }

        public Facultate GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOne(Facultate entity)
        {
            return SqlDBHelper.ExecuteNonQuery("UPDATE FACULTATE SET NUME = :Nume, ABREVIERE = :Abreviere WHERE ID_FACULTATE = :IdFacultate",
                CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2,entity.NUME,ParameterDirection.Input ),
                new OracleParameter(":Abreviere", OracleDbType.Varchar2, entity.ABREVIERE, ParameterDirection.Input),
                new OracleParameter(":IdFacultate", OracleDbType.Int32, entity.ID_FACULTATE, ParameterDirection.Input)
                );
        }
    }
}
