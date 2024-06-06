using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
namespace NivelAccesDate
{
    public class AdministrareGrupe : IStocareGrupe
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool CreateOne(Grupa grupa)
        {
            return SqlDBHelper.ExecuteNonQuery("INSERT INTO Grupe VALUES(Grupe_seq.NEXTVAL, :NumeGrupa, :AnStudiu, :IdSpecialitate)", CommandType.Text,
                new OracleParameter(":NumeGrupa", OracleDbType.Varchar2, grupa.NUME_GRUPA, ParameterDirection.Input),
                new OracleParameter(":AnStudiu", OracleDbType.Int32, grupa.AN_STUDIU, ParameterDirection.Input),
                new OracleParameter(":IdSpecialitate", OracleDbType.Int32, grupa.ID_SPECIALITATE, ParameterDirection.Input)
            );
        }

        public bool DeleteOne(int id)
        {
            string sql = @"
                BEGIN
                    UPDATE STUDENTI SET ID_GRUPA = NULL WHERE ID_GRUPA = :IdGrupa;
                    DELETE FROM GRUPE WHERE ID_GRUPA = :IdGrupa;
                    COMMIT;
                END;";

            return SqlDBHelper.ExecuteNonQuery(sql, CommandType.Text,
                new OracleParameter(":IdGrupa", OracleDbType.Int64, id, ParameterDirection.Input));
        }


        public List<Grupa> GetAll()
        {
            var result = new List<Grupa>();
            var dsGrupe = SqlDBHelper.ExecuteDataSet("SELECT * FROM GRUPE", CommandType.Text);
            foreach (DataRow ds in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Grupa(ds));
            }
            return result;
        }
       
        public List<Grupa> GetAllPopulated()
        {
            var result = new List<Grupa>();
            var dsGrupe = SqlDBHelper.ExecuteDataSet("SELECT * FROM GRUPE g JOIN Specialitate s ON g.ID_SPECIALITATE = s.ID_SPECIALITATE",CommandType.Text);
            foreach(DataRow ds in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                Grupa grupa;
                grupa = new Grupa(ds);
                if (ds.Table.Columns.Contains("NUME_SPECIALITATE") && ds.Table.Columns.Contains("ID_SPECIALITATE"))
                {
                    grupa.specialitate = new Specialitate(ds);
                }
                result.Add(grupa);

            }
            return result;

        }


        public List<Grupa> GetFilteredGrupe(int? idGrupa = null,int? anStudiu = null, int? idSpecialitate = null,int? idFacultate = null ,bool countStud = false, bool faculty = false)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT g.*, s.* ");
            if (faculty)
            {
                sql.Append(", f.* ");
            }
            if (countStud)
            {
                sql.Append(",(SELECT COUNT(*) FROM STUDENTI  WHERE ID_GRUPA = g.ID_GRUPA) AS NUMAR_STUDENTI ");
            }
            sql.Append("FROM GRUPE g ");
            sql.Append("JOIN SPECIALITATE s ON g.ID_SPECIALITATE = s.ID_SPECIALITATE ");
            if(faculty)
            {
                sql.Append("LEFT JOIN FACULTATE f ON s.ID_FACULTATE = f.ID_FACULTATE ");
            }
            sql.Append("WHERE 1=1");
            var parameters = new List<OracleParameter>();
            if (idGrupa != null)
            {
                sql.Append("AND g.ID_GRUPA = :IdGrupa");
                parameters.Add(new OracleParameter(":IdGrupa", OracleDbType.Int32) { Value = idGrupa.Value });
            }
            else
            {
                if (anStudiu.HasValue)
                {
                    sql.Append(" AND g.AN_STUDIU = :AnStudiu");
                    parameters.Add(new OracleParameter(":AnStudiu", OracleDbType.Int32) { Value = anStudiu.Value });
                }

                if (idSpecialitate.HasValue)
                {
                    sql.Append(" AND g.ID_SPECIALITATE = :IdSpecialitate");
                    parameters.Add(new OracleParameter(":IdSpecialitate", OracleDbType.Int32) { Value = idSpecialitate.Value });
                }
                if(idFacultate.HasValue)
                {
                    sql.Append(" AND f.ID_FACULTATE = :IdFacultate");
                    parameters.Add(new OracleParameter(":IdFacultate", OracleDbType.Int32) { Value=idFacultate.Value });
                }
            }


            var result = new List<Grupa>();
            var dsGrupe = SqlDBHelper.ExecuteDataSet(sql.ToString(), CommandType.Text, parameters.ToArray());
            foreach (DataRow dr in dsGrupe.Tables[0].Rows)
            {
                var grupa = new Grupa(dr);
                if(dr.Table.Columns.Contains("NUME_SPECIALITATE") && dr.Table.Columns.Contains("ID_SPECIALITATE"))
                {
                    grupa.specialitate = new Specialitate(dr);
                    if (faculty)
                    {
                        grupa.specialitate.Facultate = new Facultate(dr);
                    }
                }
                if (dr.Table.Columns.Contains("NUMAR_STUDENTI"))
                {
                    grupa.NR_STUDENTI = int.Parse(dr["NUMAR_STUDENTI"].ToString());
                }

                result.Add(grupa);
            }
            return result;
        }


        public List<string> GetDistinct(string columnName)
        {
            var result = new List<string>();

            // Build the SQL query dynamically using the specified column name
            string query = $"SELECT DISTINCT {columnName} FROM GRUPE";

            // Execute the query using SqlDBHelper
            var ds = SqlDBHelper.ExecuteDataSet(query, CommandType.Text);

            // Assuming 'PRIMUL_TABEL' is an integer constant defined elsewhere
            foreach (DataRow row in ds.Tables[PRIMUL_TABEL].Rows)
            {
                // Add the value of the specified column to the result list
                result.Add(row[columnName].ToString());
            }

            return result;
        }
        public Grupa GetOneByName(string name) {
            Grupa result = null;
            var dsGrupa = SqlDBHelper.ExecuteDataSet("SELECT * FROM GRUPE WHERE NUME_GRUPA = :NumeGrupa", CommandType.Text,
               new OracleParameter(":NumeGrupa", OracleDbType.Varchar2, name, ParameterDirection.Input));
            if (dsGrupa.Tables.Count > 0 && dsGrupa.Tables[0].Rows.Count > 0)
            {
                DataRow one = dsGrupa.Tables[0].Rows[0];
                result = new Grupa(one);
            }
            return result;
         }
        public Grupa GetOneById(int id)
        {
            Grupa result = null;
            var dsGrupa = SqlDBHelper.ExecuteDataSet("SELECT * FROM GRUPE WHERE ID_GRUPA = :id",CommandType.Text,
                new OracleParameter(":id",OracleDbType.Int64,id,ParameterDirection.Input));
            if (dsGrupa.Tables.Count > 0 && dsGrupa.Tables[0].Rows.Count > 0)
            {
                DataRow one = dsGrupa.Tables[0].Rows[0];
                result = new Grupa(one);
            }
            return result;
        }

        public bool UpdateOne(Grupa entity)
        {
            throw new NotImplementedException();
        }
    }
}
