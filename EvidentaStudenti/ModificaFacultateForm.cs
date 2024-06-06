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
   
    public partial class ModificaFacultateForm : Form
    {
        Facultate facultate;
        bool isNumeValid = false;
        bool isAbreviereValid = false;
        Button currentButton;
        AdministrareFacultate af = new AdministrareFacultate();
        public ModificaFacultateForm(Facultate f = null)
        {
            InitializeComponent();
            if(f != null)
            {
                facultate = f;
                PopulateFields(facultate);
                currentButton = butonModifica;
                buttonAdauga.Visible = false;
                butonModifica.Visible = true;
            }
            else
            {
                currentButton = buttonAdauga;
                buttonAdauga.Visible = true;
                butonModifica.Visible = false;
            }
            ValidateTextBox(textBoxNume, errorProvider1);
            ValidateTextBox(textBoxAbreviere, errorProvider2);
            UpdateButtonState();
        }
        private void ValidateTextBox(TextBox textBox, ErrorProvider errorProvider)
        {
            if (textBox.Text.Trim().Length > 1 && textBox.Text.Trim().Length < 100)
            {
                errorProvider.SetError(textBox, "");
                if (textBox == textBoxNume)
                    isNumeValid = true;
                else if (textBox == textBoxAbreviere)
                    isAbreviereValid = true;
            }
            else
            {
                errorProvider.SetError(textBox, "Invalid input. Must be between 1 and 100 characters.");
                if (textBox == textBoxNume)
                    isNumeValid = false;
                else if (textBox == textBoxAbreviere)
                    isAbreviereValid = false;
            }

            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            butonModifica.Enabled = isNumeValid && isAbreviereValid;
            buttonAdauga.Enabled = isNumeValid && isAbreviereValid;
        }
        private void PopulateFields(Facultate newFacultate)
        {
            textBoxNume.Text = newFacultate.NUME;
            textBoxAbreviere.Text = newFacultate.ABREVIERE;
        }

        private void butonModifica_Click(object sender, EventArgs e)
        {
            bool success = af.UpdateOne(facultate);
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

        private void textBoxNume_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxNume, errorProvider1);
        }

        private void textBoxAbreviere_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxAbreviere, errorProvider2);
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            facultate.NUME = textBoxNume.Text.Trim();
            facultate.ABREVIERE = textBoxAbreviere.Text.Trim();
            bool success = af.CreateOne(facultate);
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

        private void ModificaFacultateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
