using LibrarieModele;

using Oracle.ManagedDataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class SpecialitateData
    {
        public int? NumberOfGrupe { get; set; }
        public int? NumberOfStudents { get; set; }
    }
    public class AdministrareSpecialitate : IStocareSpecialitate
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;
        public bool CreateOne(Specialitate specialiTATE)
        {
            return SqlDBHelper.ExecuteNonQuery("INSERT INTO Specialitate VALUES(Specialitate_seq.NEXTVAL, :NumeSpecialitate, :ID_FACULTATE)", CommandType.Text,
                new OracleParameter(":NumeSpecialitate", OracleDbType.Varchar2, specialiTATE.NUME_SPECIALITATE, ParameterDirection.Input),
                new OracleParameter(":ID_FACULTATE",OracleDbType.Int32, specialiTATE.ID_FACULTATE, ParameterDirection.Input)
            );
        }

        public bool DeleteOne(int id)
        {
            return SqlDBHelper.ExecuteNonQuery("DELETE FROM SPECIALITATE WHERE ID_SPECIALITATE = :IdSpec", CommandType.Text,
                new OracleParameter(":IdSpec", OracleDbType.Int32, id, ParameterDirection.Input));
        }

        public List<Specialitate> GetAll()
        {
            var result = new List<Specialitate>();
            var dsSpec = SqlDBHelper.ExecuteDataSet("SELECT * FROM Specialitate", CommandType.Text);
            foreach (DataRow ds in dsSpec.Tables[PRIMUL_TABEL].Rows)
            {
                result.Add(new Specialitate(ds));
            }
            return result;
        }

        public Tuple<List<Specialitate>, Dictionary<int, SpecialitateData>> GetSpecialitateData(bool withFacultate = false)
        {
            List<Specialitate> specialitati = new List<Specialitate>();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT s.* ");
            if (withFacultate) sql.Append(" ,f.* ");
            sql.Append(" ,(SELECT COUNT(*) FROM STUDENTI WHERE ID_SPECIALITATE = s.ID_SPECIALITATE) AS NR_STUDENTI ");
            sql.Append(" ,(SELECT COUNT(*) FROM GRUPE WHERE ID_SPECIALITATE = s.ID_SPECIALITATE) AS NR_GRUPE ");
            sql.Append("FROM SPECIALITATE s ");
            if (withFacultate) sql.Append("JOIN FACULTATE f ON s.ID_FACULTATE = f.ID_FACULTATE");
           
            Dictionary<int, SpecialitateData> specialitateStatistics = new Dictionary<int, SpecialitateData>();
            var dsSpec = SqlDBHelper.ExecuteDataSet(sql.ToString(), CommandType.Text);
            foreach(DataRow ds in dsSpec.Tables[PRIMUL_TABEL].Rows)
            {
                Specialitate newSpec = new Specialitate(ds);
                if (withFacultate)
                {
                    newSpec.Facultate= new Facultate(ds);
                }
                specialitati.Add(newSpec);
                SpecialitateData spData = new SpecialitateData();
                
               
                if (ds["NR_STUDENTI"]!=DBNull.Value) 
                {
                    spData.NumberOfStudents = int.Parse(ds["NR_STUDENTI"].ToString());
                    
                }
                if (ds["NR_GRUPE"]!=DBNull.Value)
                {
                    spData.NumberOfGrupe = int.Parse(ds["NR_GRUPE"].ToString()) ;
                }
                specialitateStatistics.Add(newSpec.ID_SPECIALITATE, spData);
            }
            return Tuple.Create(specialitati, specialitateStatistics);
        }


        public List<string> GetDistinct(string columnName)
        {
            var result = new List<string>();

            // Build the SQL query dynamically using the specified column name
            string query = $"SELECT DISTINCT {columnName} FROM Specialitate";

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

        public Specialitate GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOne(Specialitate entity)
        {
            return SqlDBHelper.ExecuteNonQuery("UPDATE SPECIALITATE SET NUME_SPECIALITATE = :NumeSpec WHERE ID_SPECIALITATE = :IdSpec", CommandType.Text,
                new OracleParameter(":NumeSpec", OracleDbType.Varchar2, entity.NUME_SPECIALITATE, ParameterDirection.Input),
                new OracleParameter(":IdSpec", OracleDbType.Int32, entity.ID_FACULTATE,ParameterDirection.Input));
        }
    }
}
