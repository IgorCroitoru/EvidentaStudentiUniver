using System;
using System.Data;

namespace LibrarieModele
{
    public class Grupa
    {
        public int ID_GRUPA { get; set; }
        public string NUME_GRUPA { get; set; }
        public int AN_STUDIU { get; set; }
        public int ID_SPECIALITATE { get; set; }
        public virtual Specialitate specialitate { get; set; }
        public int? NR_STUDENTI { get; set; }
        public Grupa() { }

        public Grupa(int iD_GRUPA, string nUME_GRUPA, int aN_STUDIU, int iD_SPECIALITATE)
        {
            ID_GRUPA = iD_GRUPA;
            NUME_GRUPA = nUME_GRUPA ?? throw new ArgumentNullException(nameof(nUME_GRUPA));
            if (aN_STUDIU >= 1 || aN_STUDIU <= 7) { AN_STUDIU = aN_STUDIU; }
            else throw new ArgumentNullException(nameof(aN_STUDIU));
            ID_SPECIALITATE = iD_SPECIALITATE;
        }

        public Grupa(string nUME_GRUPA, int aN_STUDIU, int iD_SPECIALITATE)
        {
            NUME_GRUPA = nUME_GRUPA ?? throw new ArgumentNullException(nameof(nUME_GRUPA));
            if (aN_STUDIU >= 1 || aN_STUDIU <= 7) { AN_STUDIU = aN_STUDIU; }
            else throw new ArgumentNullException(nameof(aN_STUDIU));
            ID_SPECIALITATE = iD_SPECIALITATE;
        }

        public Grupa(DataRow row)
        {
            ID_GRUPA = int.Parse(row["ID_GRUPA"].ToString());
            NUME_GRUPA = row["NUME_GRUPA"].ToString();
            AN_STUDIU = int.Parse(row["AN_STUDIU"].ToString());
            ID_SPECIALITATE = int.Parse(row["ID_SPECIALITATE"].ToString());
        }

        public override string ToString()
        {
            return $"ID Grupa: {ID_GRUPA}, " +
                   $"Nume Grupa: {NUME_GRUPA}, " +
                   $"An Studiu: {AN_STUDIU}, " +
                   $"ID Specialitate: {ID_SPECIALITATE}";
        }
    }
}
