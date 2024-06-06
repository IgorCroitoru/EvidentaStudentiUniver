using LibrarieModele;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using Helper;
using System.IO;
namespace EvidentaStudenti
{
    public partial class StudentiForm : Form
    {
        AdministrareStudenti administrareStudenti = new AdministrareStudenti();
        AdministrareGrupe administrareGrupe = new AdministrareGrupe();
        AdministrareSpecialitate administrareSpecialitate = new AdministrareSpecialitate();
        AdministrareFacultate administrareFacultati = new AdministrareFacultate();
        List<string> distinctAnStudiu;
        private static readonly string DEFAULT = "All";
        private static readonly string NONE = "None";
        List<Specialitate> specialitati;
        List<Grupa> grupe;
        List<Student> studenti;
        List<Facultate> facultati;
        public StudentiForm()
        {
            InitializeComponent();
            comboBoxFacultate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            
        }

        private void dataGridDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void LoadInititalData()
        {
            var result = administrareStudenti.GetAllPopulated();
            studenti = result.Item1;

            DataGridUpdate(studenti, result.Item2);
            grupe = administrareGrupe.GetAllPopulated();
            specialitati = administrareSpecialitate.GetAll();
            FillComboBox(comboBoxGrupe, grupe, g => g.NUME_GRUPA);
            FillComboBox(comboBoxSpecialitate, specialitati, sp => sp.NUME_SPECIALITATE);
            distinctAnStudiu = administrareGrupe.GetDistinct("AN_STUDIU");
            FillComboBox(comboBoxAnStudiu, distinctAnStudiu);
            facultati = administrareFacultati.GetAll();
            FillComboBox(comboBoxFacultate, facultati, f => f.ABREVIERE);
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
            LoadInititalData();
        }

        private void FillComboBox<T>(ComboBox comboBox, List<T> items, Func<T, string> displayMember)
        {
            comboBox.Items.Clear();  // Clear any existing items

            // Add the default value "All"
            comboBox.Items.Add(DEFAULT);
            if(comboBox == comboBoxGrupe)
            {
                comboBox.Items.Add(NONE);
            }
            // Add the items from the list
            foreach (var item in items)
            {
                comboBox.Items.Add(new ComboBoxItem<T> { Value = item, DisplayText = displayMember(item) });
            }

            // Set the default selected item to "All"
            comboBox.SelectedItem =DEFAULT;
        }
        private void FillComboBox(ComboBox comboBox, List<string> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(DEFAULT);
            foreach(var item in items)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = DEFAULT;
        }
        private Student GetStudentFromSelectedRow()
        {
            if (dataGridDate.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridDate.SelectedRows[0];

            
            Student st = selectedRow.Tag as Student;
            return st;
          
        }
        private void DataGridUpdate(List<Student> students, int nrTotal = 0)
        {
            dataGridDate.Rows.Clear();
            foreach (Student student in students)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridDate,
                    student.ID_STUDENT,
                    student.CNP,
                    student.NUME,
                    student.PRENUME,
                    student.DATA_NASTERE,
                    student.NUMAR_TELEFON,
                    student.ADRESA,
                    student.Grupa?.NUME_GRUPA ?? null,
                    student.Grupa?.AN_STUDIU.ToString() ?? null,
                    student.Specialitate?.NUME_SPECIALITATE ?? null,
                    student.Specialitate?.Facultate?.ABREVIERE
                );
                row.Tag = student; // Attach the Student object as a tag to the row
                dataGridDate.Rows.Add(row);
            }
            dataGridDate.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            labelNumar.Text = nrTotal.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if(comboBox == comboBoxFacultate)
            {
                if(comboBoxFacultate.SelectedItem.ToString() != DEFAULT)
                {
                    var facultate = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                    var filteredGrupe = grupe.Where(g => g.specialitate?.ID_FACULTATE == facultate.Value.ID_FACULTATE).ToList();
                    FillComboBox(comboBoxGrupe, filteredGrupe, g => g.NUME_GRUPA);
                    var filteredSpecialitati = specialitati.Where(s => s.ID_FACULTATE == facultate.Value.ID_FACULTATE).ToList();
                    FillComboBox(comboBoxSpecialitate, filteredSpecialitati, s => s.NUME_SPECIALITATE);
                }
                else
                {
                    FillComboBox(comboBoxGrupe, grupe, g => g.NUME_GRUPA);
                    FillComboBox(comboBoxSpecialitate, specialitati, s=>s.NUME_SPECIALITATE);
                }
            }
        }
        private void comboBoxGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGrupa = comboBoxGrupe.SelectedItem?.ToString();

            // If a grupa is selected, disable the an_studiu ComboBox
            if (!string.IsNullOrEmpty(selectedGrupa) && selectedGrupa != DEFAULT && selectedGrupa !=NONE)
            {
                comboBoxAnStudiu.Enabled = false;
                comboBoxSpecialitate.Enabled = false;
                comboBoxFacultate.Enabled = false;
                //comboBoxAnStudiu.SelectedItem = DEFAULT; // Select the default value
            }
            else
            {
                comboBoxFacultate.Enabled = true;
                comboBoxSpecialitate.Enabled = true;
                comboBoxAnStudiu.Enabled = true; // Enable the an_studiu ComboBox
            }
        }

        private void ResetControls()
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0; // Assuming index 0 is your default value
                }
                else if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string idGrupa = null;
            int? idSpecialitate = null;
            int? idAnStudiu = null;
            int? idFacultate = null;
            try
            {
                if(comboBoxFacultate?.SelectedItem.ToString() != DEFAULT)
                {
                    var facult = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                    idFacultate = facult.Value.ID_FACULTATE;
                }
                if (comboBoxGrupe?.SelectedItem.ToString() != DEFAULT && comboBoxGrupe?.SelectedItem.ToString() != NONE)
                {
                    var selectedGrupa = comboBoxGrupe.SelectedItem as ComboBoxItem<Grupa>;
                    idGrupa = selectedGrupa.Value.ID_GRUPA.ToString();
                }
                else if(comboBoxGrupe?.SelectedItem.ToString() == NONE)
                {
                    idGrupa = comboBoxGrupe.SelectedItem.ToString();
                }

                if (comboBoxSpecialitate.SelectedItem.ToString() != DEFAULT)
                {
                   var selectedSpec = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
                   idSpecialitate = selectedSpec.Value.ID_SPECIALITATE;
                }

                if (comboBoxAnStudiu.SelectedItem.ToString() != DEFAULT)
                {
                    idAnStudiu = int.Parse(comboBoxAnStudiu.SelectedItem.ToString());
                }
                string fullName = textBoxNume?.Text?.ToLower();
                if (string.IsNullOrEmpty(fullName))
                {
                    fullName = null;
                }
                var result = administrareStudenti.GetFilteredStudents(idAnStudiu, idGrupa, fullName,idSpecialitate,idFacultate,true, true);
                this.DataGridUpdate(result.Item1,result.Item2);
            }
            catch (Exception ex)
            {
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetControls();
            var result = administrareStudenti.GetAllPopulated();
            DataGridUpdate(result.Item1, result.Item2);
        }

        private void labelNumar_Click(object sender, EventArgs e)
        {

        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            AdaugaStudentForm adaugaStudentForm = new AdaugaStudentForm();
            adaugaStudentForm.ShowDialog();
        }

        private void butonModifica_Click(object sender, EventArgs e)
        {
            Student student = GetStudentFromSelectedRow();
            AdaugaStudentForm modifica = new AdaugaStudentForm(student);
            modifica.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridDate.SelectedRows.Count > 0)
            {
                // Get the selected student (assuming you have a way to identify the student)
                Student selectedStudent = GetStudentFromSelectedRow();

                // Display confirmation dialog
                DialogResult dialogResult = MessageBox.Show(
                    $"Sigur vreti sa stergeti studentul '{selectedStudent.NUME + " " + selectedStudent.PRENUME}'?",
                    "Confirma stergerea",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    //// Proceed with deletion if confirmed
                    administrareStudenti.DeleteOne(selectedStudent.ID_STUDENT);
                    //UpdateStudentsDataGrid(); // Update the data grid after deletion
                }
            }
            else
            {
                //MessageBox.Show("Please select a student to delete.", "No Student Selected", MessageBoxIcon.Information);
            }
        }

        private void comboBoxAnStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAnStudiu_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSpecialitate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelSpecialitate_Click(object sender, EventArgs e)
        {

        }
    }
}
