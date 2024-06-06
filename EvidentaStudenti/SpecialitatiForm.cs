using Helper;

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
    public partial class SpecialitatiForm : Form
    {
        Tuple<List<Specialitate>, Dictionary<int, SpecialitateData>> specialitati;
        AdministrareSpecialitate administrareSpecialitate = new AdministrareSpecialitate();
        AdministrareFacultate administrareFacultate = new AdministrareFacultate();
        AdministrareStudenti administrareStudenti = new AdministrareStudenti();
        AdministrareGrupe administrareGrupe = new AdministrareGrupe();
        List<Facultate> facultati = new List<Facultate>();
        private readonly string DEFAULT = "All";
        public SpecialitatiForm()
        {
            InitializeComponent();
            specialitati = administrareSpecialitate.GetSpecialitateData(true);
            DataGridUpdate(specialitati.Item1,specialitati.Item2);
            LoadInitialData();
            buttonAvailable();
        }
        private void LoadInitialData()
        {
            facultati = administrareFacultate.GetAll();
            FillComboBox(comboBoxFacultate, facultati, f => f.ABREVIERE);
        }

        private void FillComboBox<T>(ComboBox comboBox, List<T> items, Func<T, string> displayMember)
        {
            comboBox.Items.Clear();  // Clear any existing items

            // Add the default value "All"
            comboBox.Items.Add(DEFAULT);

            // Add the items from the list
            foreach (var item in items)
            {
                comboBox.Items.Add(new ComboBoxItem<T> { Value = item, DisplayText = displayMember(item) });
            }

            // Set the default selected item to "All"
            comboBox.SelectedItem = DEFAULT;
        }
        private void DataGridUpdate(List<Specialitate> specs, Dictionary<int, SpecialitateData> specNr = null)
        {
            dataGridSpec.Rows.Clear();
            foreach (Specialitate s in specs)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridSpec,
                    s.ID_SPECIALITATE,
                    s.NUME_SPECIALITATE,
                    s.Facultate?.NUME,
                    specNr[s.ID_SPECIALITATE]?.NumberOfGrupe,
                    specNr[s.ID_SPECIALITATE]?.NumberOfStudents

                    );
                row.Tag = s;
                dataGridSpec.Rows.Add(row);
            }

        }

        private Specialitate GetSpecialitateFromSelectedRow()
        {
            if (dataGridSpec.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridSpec.SelectedRows[0];


            Specialitate spec = selectedRow.Tag as Specialitate;
            return spec;

        }

        private void buttonAvailable()
        {
            // Check if textBoxNume has text and comboBoxSpecialitate has a selection
            bool isNameValid = textBoxNume.Text.Trim().Length > 1 && textBoxNume.Text.Trim().Length < 100;
            bool isFacultateSelected = comboBoxFacultate.SelectedItem != null && comboBoxFacultate.SelectedItem.ToString() != DEFAULT;

            // Enable the button if both conditions are true
            adaugaButton.Enabled = isNameValid && isFacultateSelected;
        }
        private void adaugaButton_Click(object sender, EventArgs e)
        {
            Specialitate newSpecialitate = new Specialitate();
            var selFacult = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
            newSpecialitate.NUME_SPECIALITATE = textBoxNume.Text.Trim() ;
            newSpecialitate.ID_FACULTATE = selFacult.Value.ID_FACULTATE;
            bool success = administrareSpecialitate.CreateOne(newSpecialitate);
            if (success)
            {
                labelSuccess.ForeColor = Color.Green;
                labelSuccess.Text = "Success";
            }
            else
            {
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Text = "Eroare";
            }
        }

        private void SpecialitatiForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            buttonAvailable();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            bool isNameValid = textBoxNume.Text.Length > 1 && textBoxNume.Text.Length < 100;
            if (!isNameValid)
            {
                errorProvider1.SetError(textBoxNume, "Numele trebuie sa fie > 1 si < 100 de caractere");
            }
            else
            {
                errorProvider1.Clear();
            }
            buttonAvailable();
        }

        private void butonModifica_Click(object sender, EventArgs e)
        {
            Specialitate specForModificare = GetSpecialitateFromSelectedRow();
            ModificaSpecialitateForm form = new ModificaSpecialitateForm(specForModificare);
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string error = "";
            Specialitate s = GetSpecialitateFromSelectedRow();
            List<Student> students = new List<Student>();
            var res = administrareStudenti.GetFilteredStudents(null,string.Empty,string.Empty, s.ID_SPECIALITATE, null);
            var resGr = administrareGrupe.GetFilteredGrupe(idSpecialitate: s.ID_SPECIALITATE);
            if(res.Item1.Count>0)
            {
                error += "Nu puteti sterge specialitatea deoarece sunt studenti in ea\n";
            }
            if(resGr.Count>0)
            {
                error += "Nu puteti sterge specialitatea deoarece sunt grupe care o poseseaza";
            }
            if(!string.IsNullOrEmpty(error)) { 
                errorProvider2.SetError(deleteButton, error);
            }
            else
            {
                bool success = administrareSpecialitate.DeleteOne(s.ID_SPECIALITATE);
                if(success)
                {
                    ShowSuccessDialog("Stergere cu success");
                    DataGridUpdate(specialitati.Item1,specialitati.Item2);
                }
                else
                {
                    ShowSuccessDialog("A intervenit o eroare", "Error");
                }
                errorProvider2.Clear();
            }
        }
        private void ShowSuccessDialog(string message, string caption= "Success")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            specialitati = administrareSpecialitate.GetSpecialitateData(true);
            DataGridUpdate(specialitati.Item1, specialitati.Item2);
        }
    }
}
