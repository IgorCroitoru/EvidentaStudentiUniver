using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Helper;

using LibrarieModele;

using NivelAccesDate;
namespace EvidentaStudenti
{
    public partial class GrupeForm : Form
    {
        AdministrareGrupe administrareGrupe = new AdministrareGrupe();
        AdministrareSpecialitate administrareSpecialitate = new AdministrareSpecialitate();
        AdministrareFacultate administrareFacultate = new AdministrareFacultate();
        private static readonly string DEFAULT = "All";
        List<Grupa> Grupe;
        List<Specialitate> specialitati;
        List<string> distinctAni;
        List<Facultate> facultati;
        public GrupeForm()
        {
           
            InitializeComponent();
            LoadInitialData();
            comboBoxFacultate.SelectedIndexChanged += comboBox_SelectedIndexChangeed;

        }

        private void DataGridUpdate(List<Grupa> grupe)
        {
            dataGridGrupe.Rows.Clear();
            foreach(Grupa grupa in grupe)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridGrupe,
                    grupa.ID_GRUPA,
                    grupa.NUME_GRUPA,
                    grupa.specialitate?.NUME_SPECIALITATE,
                    grupa.AN_STUDIU,
                    grupa.NR_STUDENTI,
                    grupa.specialitate?.Facultate?.ABREVIERE
                    );
                row.Tag = grupa;
                dataGridGrupe.Rows.Add( row );
            }

        }


        private void LoadInitialData()
        {
            Grupe = administrareGrupe.GetFilteredGrupe(countStud: true, faculty: true);
            specialitati = administrareSpecialitate.GetAll();
            FillComboBox(comboBoxSpecialitate, specialitati, sp => sp.NUME_SPECIALITATE);
            distinctAni = administrareGrupe.GetDistinct("AN_STUDIU");
            FillComboBox(comboBoxAnStudiu, distinctAni);
            facultati = administrareFacultate.GetAll();
            FillComboBox(comboBoxFacultate, facultati, f => f.ABREVIERE);
        }
        private void GrupeForm_Load(object sender, EventArgs e)
        {
          
            DataGridUpdate( Grupe );
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
        private void FillComboBox(ComboBox comboBox, List<string> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(DEFAULT);
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = DEFAULT;
        }

       private void comboBox_SelectedIndexChangeed(object sender, EventArgs e)
        {
            string str = "";
            ComboBox comboBox = sender as ComboBox;
            if(comboBox == comboBoxFacultate)
            {
                if(comboBoxFacultate.SelectedItem.ToString() != DEFAULT)
                {
                    var fc = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                   
                    var filteredSpec = specialitati.Where(s=>s.ID_FACULTATE == fc.Value.ID_FACULTATE).ToList();
                    FillComboBox(comboBoxSpecialitate, filteredSpec, s => s.NUME_SPECIALITATE);

                }
                else
                {
                    FillComboBox(comboBoxSpecialitate, specialitati, s => s.NUME_SPECIALITATE);
                }
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            int? idSpec = null;
            int? an = null;
            int? idFacult = null;
            try
            {

                if (comboBoxSpecialitate.SelectedItem.ToString() != DEFAULT)
                {
                    var sp = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
                    idSpec = sp.Value.ID_SPECIALITATE;
                }

                if (comboBoxAnStudiu.SelectedItem.ToString() != DEFAULT)
                {
                    an = int.Parse(comboBoxAnStudiu.SelectedItem.ToString());
                }
                if(comboBoxFacultate.SelectedItem.ToString() != DEFAULT)
                {
                    var fac = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                    idFacult = fac.Value.ID_FACULTATE;
                }
                Grupe = administrareGrupe.GetFilteredGrupe(anStudiu: an, idSpecialitate: idSpec, idFacultate:idFacult,countStud:true,faculty:true);
                DataGridUpdate(Grupe);
                //string fullName = textBoxNume?.Text?.ToLower();
                //if (string.IsNullOrEmpty(fullName))
                //{
                //    fullName = null;
                //}
                //this.DataGridUpdate(result.Item1, result.Item2);
            }
            catch (Exception ex)
            {
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Grupe = administrareGrupe.GetFilteredGrupe(countStud: true,faculty:true);
            DataGridUpdate(Grupe);
            comboBoxAnStudiu.SelectedIndex = 0;
            comboBoxSpecialitate.SelectedIndex = 0;
        }


        private Grupa GetGrupaFromSelectedRow()
        {
            if (dataGridGrupe.SelectedRows.Count == 0)
            {
                return null;
            }

            DataGridViewRow selectedRow = dataGridGrupe.SelectedRows[0];


            Grupa st = selectedRow.Tag as Grupa;
            return st;

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridGrupe.SelectedRows.Count > 0)
            {
                // Get the selected student (assuming you have a way to identify the student)
                Grupa grupa = GetGrupaFromSelectedRow();

                // Display confirmation dialog
                DialogResult dialogResult = MessageBox.Show(
                    $"Sigur vreti sa stergeti grupa: {grupa.NUME_GRUPA}?",
                    "Confirma stergerea",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    //// Proceed with deletion if confirmed
                    administrareGrupe.DeleteOne(grupa.ID_GRUPA) ;
                    //UpdateStudentsDataGrid(); // Update the data grid after deletion
                }
            }
            else
            {
                //MessageBox.Show("Please select a student to delete.", "No Student Selected", MessageBoxIcon.Information);
            }
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            AdaugaGrupaForm adaugaGr = new AdaugaGrupaForm();
            adaugaGr.ShowDialog();
        }
    }
}
