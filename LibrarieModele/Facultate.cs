using System;
using System.Data;

namespace LibrarieModele
{
    public class Facultate
    {
        public int ID_FACULTATE { get; set; }
        public string NUME { get; set; }
        public string ABREVIERE { get; set; }

        public Facultate() { }

        public Facultate(int idFacultate, string nume, string abreviere)
        {
            ID_FACULTATE = idFacultate;
            NUME = nume ?? throw new ArgumentNullException(nameof(nume));
            ABREVIERE = abreviere ?? throw new ArgumentNullException(nameof(abreviere));
        }

        public Facultate(string nume, string abreviere)
        {
            NUME = nume ?? throw new ArgumentNullException(nameof(nume));
            ABREVIERE = abreviere ?? throw new ArgumentNullException(nameof(abreviere));
        }

        public Facultate(DataRow row)
        {
            ID_FACULTATE = int.Parse(row["ID_FACULTATE"].ToString());
            NUME = row["NUME"].ToString();
            ABREVIERE = row["ABREVIERE"].ToString();
        }

        public override string ToString()
        {
            return $"ID Facultate: {ID_FACULTATE}, " +
                   $"Nume: {NUME}, " +
                   $"Abreviere: {ABREVIERE}";
        }
    }
}
