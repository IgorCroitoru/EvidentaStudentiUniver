using System;
using System.Data;
using System.Resources;

namespace LibrarieModele
{
    public class Student
    {
        public int ID_STUDENT { get; set; }
        public DateTime DATA_NASTERE { get; set; }
        public string NUME { get; set; }
        public string PRENUME { get; set; }
        public string ADRESA { get; set; }
        public string NUMAR_TELEFON { get; set; }
        public int? ID_GRUPA { get; set; }
        public string CNP { get; set; }
        public int ID_SPECIALITATE { get; set; }
        public virtual Grupa Grupa { get; set; }
        public virtual Specialitate Specialitate { get; set; }

        public Student() { }

        public Student(int iD_STUDENT, DateTime dATA_NASTERE, string nUME, string pRENUME, int iD_SPECIALITATE, string cNP, string aDRESA = null, string nUMAR_TELEFON = null, int? iD_GRUPA = null)
        {
            if (string.IsNullOrEmpty(cNP) || cNP.Length < 7 || cNP.Length > 20)
                throw new ArgumentException("CNP must be between 7 and 20 characters.");

            ID_STUDENT = iD_STUDENT;
            DATA_NASTERE = dATA_NASTERE;
            NUME = nUME ?? throw new ArgumentNullException(nameof(nUME));
            PRENUME = pRENUME ?? throw new ArgumentNullException(nameof(pRENUME));
            CNP = cNP ?? throw new ArgumentNullException(nameof(cNP));
            ADRESA = aDRESA;
            NUMAR_TELEFON = nUMAR_TELEFON;
            ID_GRUPA = iD_GRUPA;
            ID_SPECIALITATE = iD_SPECIALITATE;
        }

        public Student(DateTime dATA_NASTERE, string nUME, string pRENUME, string cNP, int iD_SPECIALITATE, string aDRESA = null, string nUMAR_TELEFON = null, int? iD_GRUPA = null)
        {
            if (string.IsNullOrEmpty(cNP) || cNP.Length < 10 || cNP.Length > 20)
                throw new ArgumentException("CNP must be between 10 and 20 characters.");

            DATA_NASTERE = dATA_NASTERE;
            NUME = nUME ?? throw new ArgumentNullException(nameof(nUME));
            PRENUME = pRENUME ?? throw new ArgumentNullException(nameof(pRENUME));
            CNP = cNP ?? throw new ArgumentNullException(nameof(cNP));
            ADRESA = aDRESA;
            NUMAR_TELEFON = nUMAR_TELEFON;
            ID_GRUPA = iD_GRUPA;
            ID_SPECIALITATE = iD_SPECIALITATE;
        }

        public Student(DataRow row)
        {
            ID_STUDENT = int.Parse(row["ID_STUDENT"].ToString());
            DATA_NASTERE = DateTime.Parse(row["DATA_NASTERE"].ToString());
            NUME = row["NUME"].ToString();
            PRENUME = row["PRENUME"].ToString();
            CNP = row["CNP"].ToString();
            ADRESA = row["ADRESA"] != DBNull.Value ? row["ADRESA"].ToString() : null;
            NUMAR_TELEFON = row["NUMAR_TELEFON"] != DBNull.Value ? row["NUMAR_TELEFON"].ToString() : null;
            ID_GRUPA = row["ID_GRUPA"] != DBNull.Value ? int.Parse(row["ID_GRUPA"].ToString()) : (int?)null;
            ID_SPECIALITATE = int.Parse(row["ID_SPECIALITATE"].ToString());
            //if (string.IsNullOrEmpty(CNP) || CNP.Length < 10 || CNP.Length > 20)
            //    throw new ArgumentException("CNP must be between 10 and 20 characters.");
        }

        public override string ToString()
        {
            return $"ID: {ID_STUDENT}, " +
                   $"Data Nastere: {DATA_NASTERE}, " +
                   $"Nume: {NUME}, " +
                   $"Prenume: {PRENUME}, " +
                   $"CNP: {CNP}, " +
                   $"Adresa: {ADRESA}, " +
                   $"Numar Telefon: {NUMAR_TELEFON}, " +
                   $"ID Grupa: {ID_GRUPA}, "+
                   $"ID Specialitate: {ID_SPECIALITATE}";
        }
    }
}
