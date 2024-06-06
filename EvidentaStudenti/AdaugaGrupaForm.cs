using Helper;

using LibrarieModele;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EvidentaStudenti
{
    public partial class AdaugaGrupaForm : Form
    {
        AdministrareGrupe administrareGrupe = new AdministrareGrupe();
        AdministrareSpecialitate administrareSpecialitate = new AdministrareSpecialitate();
        AdministrareFacultate administrareFacultati = new AdministrareFacultate();
        List<Specialitate> specialitati;
        public int[] ani = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        List<Facultate> facultati;
        Student student;
        private static readonly string DEFAULT = "All";

        public AdaugaGrupaForm()
        {
            InitializeComponent();
            LoadInitialData();
            comboBoxFacultate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBoxSpecialitate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBoxAn.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            textBoxNume.TextChanged += textBoxNume_TextChanged;
            EnableAdaugaButton();
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

        private void FillComboBox(ComboBox comboBox, List<int> items)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(DEFAULT);
            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = DEFAULT;
        }

        private void LoadInitialData()
        {
            specialitati = administrareSpecialitate.GetAll();
            facultati = administrareFacultati.GetAll();
            FillComboBox(comboBoxAn, ani.ToList());
            FillComboBox(comboBoxSpecialitate, specialitati, sp => sp.NUME_SPECIALITATE);
            FillComboBox(comboBoxFacultate, facultati, f => f.ABREVIERE);
        }

        private void AdaugaGrupaForm_Load(object sender, EventArgs e)
        {
            // Other load operations
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox == comboBoxFacultate)
            {
                if (comboBoxFacultate.SelectedItem.ToString() != DEFAULT)
                {
                    var fc = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                    if (fc != null && fc.Value != null)
                    {
                        var filteredSpec = specialitati.Where(s => s.ID_FACULTATE == fc.Value.ID_FACULTATE).ToList();
                        FillComboBox(comboBoxSpecialitate, filteredSpec, s => s.NUME_SPECIALITATE);
                    }
                }
                else
                {
                    FillComboBox(comboBoxSpecialitate, specialitati, s => s.NUME_SPECIALITATE);
                }
            }
            

            EnableAdaugaButton();
        }

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxNume.Text;
            if (text.Length < 1 || text.Length > 20)
            {
                errorProvider1.SetError(textBoxNume, "Nume must be between 1 and 20 characters.");
            }
            else
            {
                errorProvider1.Clear();
            }
            EnableAdaugaButton();
        }

        private void EnableAdaugaButton()
        {
            bool isNameValid = textBoxNume.Text.Trim().Length >= 1 && textBoxNume.Text.Trim().Length <= 20;
            bool isFacultateSelected = comboBoxFacultate.SelectedItem != null && comboBoxFacultate.SelectedItem.ToString() != DEFAULT;
            bool isSpecialitateSelected = comboBoxSpecialitate.SelectedItem != null && comboBoxSpecialitate.SelectedItem.ToString() != DEFAULT;
            bool isAnSelected = comboBoxAn.SelectedItem != null && comboBoxAn.SelectedItem.ToString() != DEFAULT;
            buttonAdauga.Enabled = isNameValid && isFacultateSelected && isSpecialitateSelected && isAnSelected;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            var selectedSpec = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
            Grupa exist = administrareGrupe.GetOneByName(textBoxNume.Text.Trim());
            if (exist!=null)
            {
                errorProvider1.SetError(buttonAdauga, $"Numele [ {textBoxNume.Text.Trim()} ] deja exista in baza de date");
                return;
            }
            Grupa gr = new Grupa
            {
                AN_STUDIU = int.Parse(comboBoxAn.SelectedItem.ToString()),
                ID_SPECIALITATE = selectedSpec.Value.ID_SPECIALITATE,
                NUME_GRUPA = textBoxNume.Text.Trim()
            };
            bool success = administrareGrupe.CreateOne(gr);
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
    }
}
