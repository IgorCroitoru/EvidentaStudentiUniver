using System;
using System.Data;

namespace LibrarieModele
{
    public class Specialitate
    {
        public int ID_SPECIALITATE { get; set; }
        public string NUME_SPECIALITATE { get; set; }
        public int ID_FACULTATE { get; set; }
        public virtual Facultate Facultate { get; set; }
        public Specialitate() { }

        public Specialitate(int iD_SPECIALIZARE, string nUME_SPECIALIZARE)
        {
            ID_SPECIALITATE = iD_SPECIALIZARE;
            NUME_SPECIALITATE = nUME_SPECIALIZARE ?? throw new ArgumentNullException(nameof(nUME_SPECIALIZARE));
        }

        public Specialitate(string nUME_SPECIALIZARE)
        {
            NUME_SPECIALITATE = nUME_SPECIALIZARE ?? throw new ArgumentNullException(nameof(nUME_SPECIALIZARE));
        }

        public Specialitate(DataRow row)
        {
            ID_SPECIALITATE = int.Parse(row["ID_SPECIALITATE"].ToString());
            NUME_SPECIALITATE = row["NUME_SPECIALITATE"].ToString();
            ID_FACULTATE = int.Parse(row["ID_FACULTATE"].ToString());
        }

        public override string ToString()
        {
            return $"ID Specialitate: {ID_SPECIALITATE}, " +
                   $"Nume Specialitate: {NUME_SPECIALITATE}";
        }
    }
}
