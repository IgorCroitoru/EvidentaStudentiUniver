using LibrarieModele;

using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareStudenti:IStocareStudenti
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public AdministrareStudenti() { }
        public bool CreateOne(Student obj)
        {
            return SqlDBHelper.ExecuteNonQuery("INSERT INTO STUDENTI VALUES(Studenti_seq.NEXTVAL, :DataNastere, :Nume, :Prenume, :Adresa, :NrTel, :CNP,:IdGrupa, :IdSpecialitate)", CommandType.Text,
                new OracleParameter(":DataNastere", OracleDbType.Date, obj.DATA_NASTERE, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.Varchar2, obj.NUME,ParameterDirection.Input),
                new OracleParameter(":Prenume",OracleDbType.Varchar2, obj.PRENUME,ParameterDirection.Input),
                new OracleParameter(":Adresa",OracleDbType.Varchar2,obj.ADRESA,ParameterDirection.Input),
                new OracleParameter(":NrTel", OracleDbType.Varchar2,obj.NUMAR_TELEFON,ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.Varchar2, obj.CNP, ParameterDirection.Input),
                new OracleParameter(":IdGrupa",OracleDbType.Int64,obj.ID_GRUPA,ParameterDirection.Input),
            
                new OracleParameter(":IdSpecialitate", OracleDbType.Int64,obj.ID_SPECIALITATE,ParameterDirection.Input)
                );
           
        }

        public bool DeleteOne(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM STUDENTI WHERE ID_STUDENT = :IdStudent ", CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, id, ParameterDirection.Input)
                );
        }

        public List<Student> GetAll()
        {
            var result = new List<Student>();
            var dsStudenti = SqlDBHelper.ExecuteDataSet("SELECT * FROM STUDENTI", CommandType.Text);
            foreach (DataRow ds in dsStudenti.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Student(ds));
            }
            return result;
        }

        public (List<Student>, int) GetFilteredStudents(int? anStudiu, string grupaId, string fullName, int? idSpec,int? idFacultate ,bool populateSpec = false, bool getFacultate = false)
        {
            int total = 0;
            var sql = new StringBuilder();
            sql.Append("SELECT COUNT(*) OVER() AS TOTAL_RECORDS, ");
            if (populateSpec)
            {
                sql.Append("sp.*, ");
            }
            sql.Append("s.*, g.* ");
            if (populateSpec && getFacultate)
            {
                sql.Append(", f.* ");
            }
            sql.Append("FROM STUDENTI s ");
            sql.Append("LEFT JOIN GRUPE g ON s.ID_GRUPA = g.ID_GRUPA ");
            if (populateSpec)
            {
                sql.Append("LEFT JOIN SPECIALITATE sp ON s.ID_SPECIALITATE = sp.ID_SPECIALITATE ");
                if (getFacultate)
                {
                    sql.Append("LEFT JOIN FACULTATE f ON sp.ID_FACULTATE = f.ID_FACULTATE ");
                }
            }
            sql.Append("WHERE 1=1 ");

            var parameters = new List<OracleParameter>();

            if (anStudiu != null)
            {
                sql.Append("AND g.AN_STUDIU = :AnStudiu ");
                parameters.Add(new OracleParameter(":AnStudiu", OracleDbType.Int64) { Value = anStudiu });
            }

            if (grupaId == "None")
            {
                sql.Append("AND s.ID_GRUPA IS NULL ");
            }
            else if (!string.IsNullOrEmpty(grupaId))
            {
                sql.Append("AND g.ID_GRUPA = :Grupa ");
                parameters.Add(new OracleParameter(":Grupa", OracleDbType.Int64) { Value = grupaId });
            }
            if (idSpec != null)
            {
                sql.Append("AND s.ID_SPECIALITATE = :IdSpec ");
                parameters.Add(new OracleParameter("IdSpec", OracleDbType.Int64) { Value = idSpec });
            }
            if (!string.IsNullOrEmpty(fullName))
            {
                sql.Append("AND LOWER(CONCAT(s.NUME, s.PRENUME)) LIKE :FullName ");
                parameters.Add(new OracleParameter(":FullName", OracleDbType.Varchar2) { Value = "%" + fullName.ToLower() + "%" });
            }
            if (idFacultate.HasValue)
            {
                sql.Append("AND f.ID_FACULTATE = :IdFacultate ");
                parameters.Add(new OracleParameter("IdFacultate", OracleDbType.Int64) { Value = idFacultate.Value });
            }

            var result = new List<Student>();
            var dsStudenti = SqlDBHelper.ExecuteDataSet(sql.ToString(), CommandType.Text, parameters.ToArray());
            foreach (DataRow dr in dsStudenti.Tables[0].Rows)  // Assuming the first table in DataSet contains the results
            {
                var student = new Student(dr);
                if (dr["ID_GRUPA"] != DBNull.Value)
                {
                    student.Grupa = new Grupa(dr);
                }
                if (dr["ID_SPECIALITATE"] != DBNull.Value && populateSpec)
                {
                    student.Specialitate = new Specialitate(dr);
                    if (getFacultate && dr["ID_FACULTATE"] != DBNull.Value)
                    {
                        student.Specialitate.Facultate = new Facultate(dr);
                    }
                }
                if (dr["TOTAL_RECORDS"] != DBNull.Value)
                {
                    total = Convert.ToInt32(dr["TOTAL_RECORDS"]);
                }
                result.Add(student);
            }
            return (result, total);
        }

        public (List<Student>,int) GetAllPopulated()
        {
            int total = 0;
            string sql = "SELECT COUNT(*) OVER() AS TOTAL_RECORDS, " +
                        "sp.*," +
                        "s.*," +
                        "f.*," +
                        "g.* " +
                        "FROM STUDENTI s " +
                        "LEFT JOIN GRUPE g ON s.ID_GRUPA = g.ID_GRUPA " +
                        "LEFT JOIN SPECIALITATE sp ON s.ID_SPECIALITATE = sp.ID_SPECIALITATE " +
                        "LEFT JOIN FACULTATE f ON sp.ID_FACULTATE = f.ID_FACULTATE ";
            var result = new List<Student>();
            var dsStudenti = SqlDBHelper.ExecuteDataSet(sql,CommandType.Text);
            foreach(DataRow dr in dsStudenti.Tables[PRIMUL_TABEL].Rows) {

                var student = new Student(dr);

                // Check if the student has a group (Grupa)
                if (dr["ID_GRUPA"] != DBNull.Value)
                {
                    // Create a Grupa object only if the group data is not null
                    student.Grupa = new Grupa(dr);
                }
                if (dr["ID_SPECIALITATE"] != DBNull.Value)
                {
                    student.Specialitate = new Specialitate(dr);
                    if (dr["ID_FACULTATE"] != DBNull.Value)
                    {
                        student.Specialitate.Facultate = new Facultate(dr);
                    }
                }
                if (dr["TOTAL_RECORDS"] != DBNull.Value)
                {
                    total = int.Parse(dr["TOTAL_RECORDS"].ToString());
                }
              

                // Add the student to the result list
                result.Add(student);

            }
         
            return (result,total);
        }

        public List<string> GetDistinct(string distinct)
        {
            throw new NotImplementedException();
        }

        public Student GetOneById(int id)
        {
            throw new NotImplementedException();
        }
        public bool Test()
        {
            return SqlDBHelper.ExecuteNonQuery("UPDATE STUDENTI SET DATA_NASTERE = :DataNastere WHERE ID_STUDENT = 21", CommandType.Text,
                new OracleParameter(":DataNastere", OracleDbType.Date, new DateTime(2000,10,20), ParameterDirection.Input)
                );
        }

        public bool UpdateOne(Student obj)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE STUDENTI ");

            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE STUDENTI " +
                "SET DATA_NASTERE = :DataNastere, NUME = :Nume, PRENUME = :Prenume, CNP = :CNP, ID_GRUPA = :IdGrupa, ID_SPECIALITATE = :IdSpecialitate " +
                "WHERE ID_STUDENT = :IdStudent",
                CommandType.Text,
                new OracleParameter(":DataNastere", OracleDbType.Date, obj.DATA_NASTERE, ParameterDirection.Input),
                new OracleParameter(":Nume", OracleDbType.Varchar2, obj.NUME, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, obj.PRENUME, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.Varchar2, obj.CNP, ParameterDirection.Input),
                new OracleParameter(":IdGrupa", OracleDbType.Int32, obj.ID_GRUPA.HasValue ? (object)obj.ID_GRUPA.Value : DBNull.Value, ParameterDirection.Input),
                new OracleParameter(":IdSpecialitate", OracleDbType.Int32, obj.ID_SPECIALITATE, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int64, obj.ID_STUDENT, ParameterDirection.Input)
            );
        }

    }
}
