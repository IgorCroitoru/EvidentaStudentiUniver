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
    public partial class ModificaSpecialitateForm : Form
    {
        Specialitate specialitate;
        AdministrareSpecialitate asp = new AdministrareSpecialitate();
        public ModificaSpecialitateForm(Specialitate spec)
        {
            specialitate = spec;
            InitializeComponent();
            fillFields(spec);
            buttonAvailable();
            
        }
        private void buttonAvailable()
        {
            // Check if textBoxNume has text and comboBoxSpecialitate has a selection
            bool isNameValid = textBoxNume.Text.Trim().Length > 1 && textBoxNume.Text.Trim().Length < 100;

            // Enable the button if both conditions are true
            butonModifica.Enabled = isNameValid;
        }
        private void fillFields(Specialitate s)
        {
            textBoxNume.Text = s.NUME_SPECIALITATE;
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
            specialitate.NUME_SPECIALITATE = textBoxNume.Text;
            bool success = asp.UpdateOne(specialitate);
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
