using LibrarieModele;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaStudenti
{
    public partial class FacultateForm : Form
    {
        AdministrareFacultate administrareFacultate = new AdministrareFacultate();
        Tuple<List<Facultate>, Dictionary<int, FacultateData>> tuple;
        public FacultateForm()
        {
            InitializeComponent();
            tuple = administrareFacultate.GetFacultateData();
            UpdateDataGrid(tuple.Item1,tuple.Item2);
        }

        private void UpdateDataGrid(List<Facultate> facult, Dictionary<int, FacultateData> fd = null)
        {
            dataGridFacultate.Rows.Clear();
            foreach (Facultate f in facult)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridFacultate,
                    f.ID_FACULTATE,
                    f.NUME,
                    f.ABREVIERE,
                    (fd != null && fd.ContainsKey(f.ID_FACULTATE)) ? fd[f.ID_FACULTATE].NumberOfStudents : 0,
                    (fd != null && fd.ContainsKey(f.ID_FACULTATE)) ? fd[f.ID_FACULTATE].NumberOfGrupe : 0,
                    (fd != null && fd.ContainsKey(f.ID_FACULTATE)) ? fd[f.ID_FACULTATE].NumberOfSpecialitati : 0
                    );
                row.Tag = f;
                dataGridFacultate.Rows.Add(row);
            }
        }
        private Facultate GetFacultateFromSelectedRow()
        {
            if (dataGridFacultate.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridFacultate.SelectedRows[0];


            Facultate st = selectedRow.Tag as Facultate;
            return st;

        }
        private void buttonModifica_Click(object sender, EventArgs e)
        {
            Facultate f = GetFacultateFromSelectedRow();
            ModificaFacultateForm mff = new ModificaFacultateForm(f);
            mff.ShowDialog();
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            ModificaFacultateForm mff = new ModificaFacultateForm();
            mff.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Facultate f = GetFacultateFromSelectedRow();
            if (administrareFacultate.CanBeDeleted(f.ID_FACULTATE))
            {
                if (administrareFacultate.DeleteOne(f.ID_FACULTATE))
                {
                    MessageBox.Show("Facultate a fost ștearsă cu succes!", "Ștergere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A intervenit o eroare in șteargerea facultatii!", "Ștergere eșuată", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("In facultate sunt inscrisi studenti si nu poate fi stearsa!", "Ștergere eșuată", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
