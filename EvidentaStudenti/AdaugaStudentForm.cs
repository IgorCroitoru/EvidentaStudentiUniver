using Helper;

using LibrarieModele;

using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace EvidentaStudenti
{
    public struct LengthConstraints
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public LengthConstraints(int minLength, int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
    public partial class AdaugaStudentForm : Form
    {
        
        private static readonly LengthConstraints NUME_LEN = new LengthConstraints(2,50);
        private static readonly LengthConstraints PRENUME_LEN =new LengthConstraints(2, 50);
        private static readonly LengthConstraints NUMAR_LEN =  new LengthConstraints(7,13);
        private static readonly LengthConstraints ADRESA_LEN = new LengthConstraints( 0,50);
        private static readonly LengthConstraints CNP_LEN = new LengthConstraints(6,13);
        private static readonly string DEFAULT = "All";
        
        const string DIGITS_ONLY_REGEX = @"^\d*$";

        AdministrareGrupe administrareGrupe = new AdministrareGrupe();
        AdministrareSpecialitate administrareSpecialitate = new AdministrareSpecialitate();
        AdministrareFacultate administrareFacultati = new AdministrareFacultate();
        List<Specialitate> specialitati;
        List<Grupa> grupe;
        List<Facultate> facultati;
        Student student;
        Button currentButton;
        public AdaugaStudentForm(Student studentNew = null)
        {
            InitializeComponent();
            
            if (studentNew != null)
            {
                student = studentNew;
                LoadInitialData();
                //populateFields(studentNew);
                currentButton = buttonModifica;
                buttonAdauga.Visible = false;
                buttonModifica.Visible = true;
                if (student.ID_GRUPA != null)
                {
                    var selectedGrupa = grupe.FirstOrDefault(g => g.ID_GRUPA == student.ID_GRUPA);
                    if (selectedGrupa != null)
                    {
                        LockComboBoxesForGrupa(selectedGrupa);
                    }
                }
            }
            
            else
            {
                LoadInitialData();
                currentButton = buttonAdauga;
                buttonAdauga.Visible = true;
                buttonModifica.Visible = false;
            }
            
            textBoxCNP.TextChanged += TextBox_TextChanged;
            textBoxNrTel.TextChanged += TextBox_TextChanged;
            textBoxStrada.TextChanged += TextBox_TextChanged;
            textBoxNume.TextChanged += TextBox_TextChanged;

            textBoxPrenume.TextChanged += TextBox_TextChanged;

            comboBoxGrupa.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBoxAn.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBoxSpecialitate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBoxFacultate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            if(student!=null) populateFields(studentNew);
            EnableButtonIfValid(currentButton);
            //comboBoxAn.SelectedIndexChanged += ComboBoxAn_SelectedIndexChanged;
            //comboBoxGrupa.SelectedIndexChanged += ComboBoxGrupa_SelectedIndexChanged;




        }
        private void LockComboBoxesForGrupa(Grupa grupa)
        {
            if (grupa != null)
            {
                ComboBoxHelper.LockComboBox(comboBoxAn, grupa.AN_STUDIU.ToString());
                ComboBoxHelper.LockComboBox(comboBoxSpecialitate, grupa.specialitate.NUME_SPECIALITATE);
                Facultate facultate = facultati.Where(f => f.ID_FACULTATE == grupa.specialitate.ID_FACULTATE).FirstOrDefault();
                ComboBoxHelper.LockComboBox(comboBoxFacultate, facultate.ABREVIERE);
            }
        }
        private void populateFields(Student s)
        {
            textBoxCNP.Text = s.CNP;
            textBoxNrTel.Text = s.NUMAR_TELEFON;
            textBoxNume.Text = s.NUME;
            textBoxPrenume.Text = s.PRENUME;
            textBoxStrada.Text = s.ADRESA;
            dateTimeAnNastere.Value = s.DATA_NASTERE;
            int index = -1;
            foreach (var item in comboBoxSpecialitate.Items)
            {
                if (item is ComboBoxItem<Specialitate> comboBoxItem)
                {
                    if (comboBoxItem.Value != null && comboBoxItem.Value.ID_SPECIALITATE == s.ID_SPECIALITATE)
                    {
                        index = comboBoxSpecialitate.FindStringExact(comboBoxItem.Value.NUME_SPECIALITATE.ToString());
                        comboBoxSpecialitate.SelectedIndex = index;
                        break;
                    }
                }
            }
            //labelTest.Text = s.ToString();
            if (s.ID_GRUPA != null)
            {
                foreach (var item in comboBoxGrupa.Items)
                {
                    if (item is ComboBoxItem<Grupa> comboBoxItem)
                    {
                        if (comboBoxItem.Value != null && comboBoxItem.Value.ID_GRUPA == s.ID_GRUPA)
                        {
                            index = comboBoxGrupa.FindStringExact(comboBoxItem.Value.NUME_GRUPA);
                            comboBoxGrupa.SelectedIndex = index;
                            break;
                        }
                    }
                }
            }

        }



        private void ComboBoxGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComboBoxAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox == comboBoxFacultate)
            {
                if (comboBoxFacultate.SelectedItem.ToString() != DEFAULT)
                {
                    var facultate = comboBoxFacultate.SelectedItem as ComboBoxItem<Facultate>;
                    if (facultate != null && facultate.Value != null)
                    {
                        var filteredSpecialitati = specialitati.Where(s => s.ID_FACULTATE == facultate.Value.ID_FACULTATE).ToList();
                        FillComboBox(comboBoxSpecialitate, filteredSpecialitati, s => s.NUME_SPECIALITATE);

                        // Filter groups based on the selected faculty's specialities
                        var filteredGrupe = grupe.Where(g => filteredSpecialitati.Any(s => s.ID_SPECIALITATE == g.ID_SPECIALITATE)).ToList();
                        FillComboBox(comboBoxGrupa, filteredGrupe, g => g.NUME_GRUPA);
                    }
                }
                else
                {
                    FillComboBox(comboBoxGrupa, grupe, g => g.NUME_GRUPA);
                    FillComboBox(comboBoxSpecialitate, specialitati, s => s.NUME_SPECIALITATE);
                }
            }
            else if (comboBox == comboBoxGrupa)
            {
                comboBoxAn.SelectedIndexChanged -= comboBox_SelectedIndexChanged;
                comboBoxSpecialitate.SelectedIndexChanged -= comboBox_SelectedIndexChanged;
                comboBoxFacultate.SelectedIndexChanged -= comboBox_SelectedIndexChanged;

                if (comboBox.SelectedItem.ToString() != DEFAULT)
                {
                    var selectedItem = comboBox.SelectedItem as ComboBoxItem<Grupa>;
                    if (selectedItem != null && selectedItem.Value != null)
                    {
                        Grupa grupa = selectedItem.Value;
                        Facultate facultate = facultati.FirstOrDefault(f => f.ID_FACULTATE == grupa.specialitate.ID_FACULTATE);
                        ComboBoxHelper.LockComboBox(comboBoxAn, grupa.AN_STUDIU.ToString());
                        ComboBoxHelper.LockComboBox(comboBoxFacultate, facultate.ABREVIERE);
                        ComboBoxHelper.LockComboBox(comboBoxSpecialitate, grupa.specialitate.NUME_SPECIALITATE);
                    }
                    else
                    {
                        ComboBoxHelper.UnlockComboBox(comboBoxFacultate);
                        ComboBoxHelper.UnlockComboBox(comboBoxAn);
                        ComboBoxHelper.UnlockComboBox(comboBoxSpecialitate);
                    }
                }
                else
                {
                    ComboBoxHelper.UnlockComboBox(comboBoxFacultate);
                    ComboBoxHelper.UnlockComboBox(comboBoxAn);
                    ComboBoxHelper.UnlockComboBox(comboBoxSpecialitate);
                }

                comboBoxAn.SelectedIndexChanged += comboBox_SelectedIndexChanged;
                comboBoxSpecialitate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
                comboBoxFacultate.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            }
            else if (comboBox == comboBoxAn || comboBox == comboBoxSpecialitate)
            {
                if (comboBoxAn.SelectedItem.ToString() != DEFAULT && comboBoxSpecialitate.SelectedItem.ToString() != DEFAULT)
                {
                    var selectedSpecialitate = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
                    if (selectedSpecialitate != null && selectedSpecialitate.Value != null)
                    {
                        Specialitate spec = selectedSpecialitate.Value;
                        var filteredGrupe = grupe.Where(g => g.AN_STUDIU == int.Parse(comboBoxAn.SelectedItem.ToString()) && g.ID_SPECIALITATE == spec.ID_SPECIALITATE).ToList();
                        FillComboBox(comboBoxGrupa, filteredGrupe, g => g.NUME_GRUPA);
                    }
                }
                else if (comboBoxAn.SelectedItem.ToString() != DEFAULT)
                {
                    var an = comboBoxAn.SelectedItem.ToString();
                    List<Grupa> filtered = grupe.Where(g => g.AN_STUDIU == int.Parse(an)).ToList();
                    FillComboBox(comboBoxGrupa, filtered, g => g.NUME_GRUPA);
                }
                else if (comboBoxSpecialitate.SelectedItem?.ToString() != DEFAULT)
                {
                    var selectedSpecialitate = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
                    if (selectedSpecialitate != null)
                    {
                        Specialitate spec = selectedSpecialitate.Value;
                        var filteredGrupe = grupe.Where(g => g.specialitate.ID_SPECIALITATE == spec.ID_SPECIALITATE).ToList();
                        FillComboBox(comboBoxGrupa, filteredGrupe, g => g.NUME_GRUPA);
                    }
                }
                else
                {
                    FillComboBox(comboBoxGrupa, grupe, g => g.NUME_GRUPA);
                }
            }

            EnableButtonIfValid(currentButton);
        }








        private void LoadInitialData()
        {
            specialitati = administrareSpecialitate.GetAll();
           
            grupe = administrareGrupe.GetAllPopulated();
            facultati = administrareFacultati.GetAll();
            FillComboBox(comboBoxAn, grupe.Select(g => g.AN_STUDIU.ToString()).Distinct().ToList());
            FillComboBox(comboBoxSpecialitate, specialitati, sp => sp.NUME_SPECIALITATE);
            FillComboBox(comboBoxGrupa, grupe, g => g.NUME_GRUPA);
            FillComboBox(comboBoxFacultate, facultati, f => f.ABREVIERE);
        }

        private void EnableButtonIfValid(Button button)
        {
            var (isValid, _) = validateButton();
            button.Enabled = isValid;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Cast the sender object back to a TextBox
            TextBox textBox = sender as TextBox;

            // Check if the TextBox is null
            if (textBox == null)
                return;

            // Validate the length and regex, and get the combined error message


            // Set the combined error message
            EnableButtonIfValid(currentButton);
            GetErrorProvider(textBox).SetError(textBox, GetErrorMessage(textBox));
        }


        private (bool, string) validateButton()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    string error = GetErrorMessage(t);
                    if (!string.IsNullOrEmpty(error))
                    {
                        return (false, error); // If any textbox has an error, return false with the error message
                    }
                }
            }

            //if (comboBoxGrupa.SelectedItem == null || comboBoxGrupa.SelectedItem.ToString() == DEFAULT)
            //{
            //    return (false, "Please select a valid group.");
            //}

            return (true, string.Empty); // If all textboxes are error-free and group is selected, return true
        }

        private string GetErrorMessage(TextBox textBox)
        {
            string errorMessage = string.Empty;
            errorMessage = ValidateTextBoxLength(textBox);

            if (textBox == textBoxNrTel)
            {
                errorMessage = CombineErrorMessages(errorMessage, ValidateTextBoxWithRegex(textBox, DIGITS_ONLY_REGEX, "Phone number must contain only digits."));
            }
            else if (textBox == textBoxCNP)
            {
                errorMessage = CombineErrorMessages(errorMessage, ValidateTextBoxWithRegex(textBox, DIGITS_ONLY_REGEX, "CNP must contain only digits."));
            }

            return errorMessage;
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
        private string ValidateTextBoxLength(TextBox textBox)
        {
            int minLength = GetMinLength(textBox);
            int maxLength = GetMaxLength(textBox);
            int length = textBox.Text.Trim().Length;

            if (length < minLength)
            {
                return $"Text length must be at least {minLength} characters.";
            }
            if (length > maxLength)
            {
                return $"Text length must be no more than {maxLength} characters.";
            }

            return string.Empty;
        }
        private string ValidateTextBoxWithRegex(TextBox textBox, string pattern, string errorMessage)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                return errorMessage;
            }

            return string.Empty;
        }

        private string CombineErrorMessages(string errorMessage1, string errorMessage2)
        {
            if (string.IsNullOrEmpty(errorMessage1))
            {
                return errorMessage2;
            }
            if (string.IsNullOrEmpty(errorMessage2))
            {
                return errorMessage1;
            }

            return $"{errorMessage1} {errorMessage2}";
        }

        //private void EnableButtonIfValid()
        //{
        //    // Check all text boxes' validations
        //    bool allValid = 

        //    // Enable the button if all validations pass, disable it otherwise
        //    buttonAdauga.Enabled = allValid;
        //}

        private int GetMinLength(TextBox textBox)
        {
            // Implement this method to return the minimum length for the specified TextBox
            // Example:
            if (textBox == textBoxNume)
            {
                return NUME_LEN.MinLength; // Minimum length for textBoxNume
            }
            else if (textBox == textBoxCNP)
            {
                return CNP_LEN.MinLength; // Minimum length for textBoxCNP
            }
            else if (textBox == textBoxPrenume)
            {
                return PRENUME_LEN.MinLength; // Minimum length for textBoxPrenume
            }
            else if (textBox == textBoxNrTel)
            {
                return NUMAR_LEN.MinLength; // Minimum length for textBoxNrTel
            }
            else if (textBox == textBoxStrada)
            {
                return ADRESA_LEN.MinLength; // Minimum length for textBoxStrada
            }
            else return 0;
        }
        private int GetMaxLength(TextBox textBox)
        {
            // Implement this method to return the maximum length for the specified TextBox
            // Example:
            if (textBox == textBoxNume)
            {
                return NUME_LEN.MaxLength; // Maximum length for textBox1
            }
            else if (textBox == textBoxCNP)
            {
                return CNP_LEN.MaxLength; // Maximum length for textBox2
            }
            else if(textBox == textBoxPrenume)
            {
                return PRENUME_LEN.MaxLength;
            }
            else if(textBox == textBoxNrTel)
            {
                return NUMAR_LEN.MaxLength;
            }
            else if(textBox == textBoxStrada)
            {
                return ADRESA_LEN.MaxLength;
            }
            else return 0;
            // Add more conditions for other textboxes as needed
        }

        private ErrorProvider GetErrorProvider(TextBox textBox)
        {
            // Implement this method to return the error provider for the specified TextBox
            // Example:
            if (textBox == textBoxPrenume)
            {
                return errorProvider1; // Error provider for textBox1
            }
            else if (textBox == textBoxCNP)
            {
                return errorProvider2; // Error provider for textBox2
            }
            else if(textBox == textBoxStrada){
                return errorProvider3;
            }
            else if(textBox == textBoxNrTel)
            {
                return errorProvider4;
            }
            else if(textBox == textBoxNume)
            {
                return errorProvider5;
            }
            else return null;
            // Add more conditions for other textboxes as needed
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = validateButton();
            if (isValid)
            {
                errorProvider6.Clear();
                var selectedgr = comboBoxGrupa.SelectedItem as ComboBoxItem<Grupa>;
                student = new Student
                {
                    NUME = textBoxNume.Text.Trim(),
                    PRENUME = textBoxPrenume.Text.Trim(),
                    ADRESA = textBoxStrada.Text.Trim(),
                    NUMAR_TELEFON = textBoxNrTel.Text.Trim(),
                    CNP = textBoxCNP.Text.Trim(),
                    DATA_NASTERE = dateTimeAnNastere.Value,
                    ID_GRUPA = selectedgr?.Value.ID_GRUPA,
                    ID_SPECIALITATE = selectedgr.Value.ID_SPECIALITATE,
                };
                File.WriteAllText("C:\\Users\\Igor\\source\\repos\\EvidentaStudenti\\NivelAccesDate\\file.txt", student.ToString());
                AdministrareStudenti admStd = new AdministrareStudenti();
                bool raspuns = admStd.CreateOne(student);
                if (raspuns)
                {
                    labelSuccess.ForeColor = Color.Green;
                    labelSuccess.Text = "Success";
                }
                else
                {
                    labelSuccess.ForeColor= Color.Red;
                    labelSuccess.Text = "Eroare";
                }
                // Proceed with adding the student
            }
            else
            {
                errorProvider6.SetError(currentButton, errorMessage);
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            var (isValid, errorMessage) = validateButton();
            if (isValid)
            {
                errorProvider6.Clear();
                Grupa selectedGrupa = null;
                if (comboBoxGrupa.SelectedItem.ToString() != DEFAULT)
                {
                    var selectedgr = comboBoxGrupa.SelectedItem as ComboBoxItem<Grupa>;
                    selectedGrupa = selectedgr.Value;
                }
                Specialitate selectedSpec = null;
                if (comboBoxSpecialitate.SelectedItem.ToString() != DEFAULT)
                {
                    var spec = comboBoxSpecialitate.SelectedItem as ComboBoxItem<Specialitate>;
                    selectedSpec = spec.Value;
                }

                Student newStudent = new Student
                {
                    ID_STUDENT = student.ID_STUDENT,
                    NUME = textBoxNume.Text.Trim(),
                    PRENUME = textBoxPrenume.Text.Trim(),
                    ADRESA = textBoxStrada.Text.Trim(),
                    NUMAR_TELEFON = textBoxNrTel.Text.Trim(),
                    CNP = textBoxCNP.Text.Trim(),
                    DATA_NASTERE = dateTimeAnNastere.Value
                };

                if (selectedGrupa != null)
                {
                    newStudent.ID_GRUPA = selectedGrupa.ID_GRUPA;
                    newStudent.ID_SPECIALITATE = selectedGrupa.ID_SPECIALITATE;
                }
                else if (selectedSpec != null)
                {
                    newStudent.ID_GRUPA = null;
                    newStudent.ID_SPECIALITATE = selectedSpec.ID_SPECIALITATE;
                }
                else
                {
                    newStudent.ID_GRUPA = null;
                }

                AdministrareStudenti admStd = new AdministrareStudenti();
                bool raspuns = admStd.UpdateOne(newStudent);
                if (raspuns)
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
            else
            {
                errorProvider6.SetError(currentButton, errorMessage);
            }
        }

        private void AdaugaStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
