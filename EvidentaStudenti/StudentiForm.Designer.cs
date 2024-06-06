namespace EvidentaStudenti
{
    partial class StudentiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridDate = new System.Windows.Forms.DataGridView();
            this.comboBoxGrupe = new System.Windows.Forms.ComboBox();
            this.labelGrupa = new System.Windows.Forms.Label();
            this.labelAnStudiu = new System.Windows.Forms.Label();
            this.comboBoxAnStudiu = new System.Windows.Forms.ComboBox();
            this.labelSpecialitate = new System.Windows.Forms.Label();
            this.comboBoxSpecialitate = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNumeSearch = new System.Windows.Forms.Label();
            this.labelNrTotalText = new System.Windows.Forms.Label();
            this.labelNumar = new System.Windows.Forms.Label();
            this.deleteButton = new EvidentaStudenti.Butoane.RJButton();
            this.butonModifica = new EvidentaStudenti.Butoane.RJButton();
            this.adaugaButton = new EvidentaStudenti.Butoane.RJButton();
            this.resetButton = new EvidentaStudenti.Butoane.RJButton();
            this.searchButton = new EvidentaStudenti.Butoane.RJButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNastere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnStudiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSpecialitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDate
            // 
            this.dataGridDate.AllowUserToAddRows = false;
            this.dataGridDate.AllowUserToDeleteRows = false;
            this.dataGridDate.AllowUserToOrderColumns = true;
            this.dataGridDate.AllowUserToResizeColumns = false;
            this.dataGridDate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridDate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColCNP,
            this.ColNume,
            this.ColPrenume,
            this.ColNastere,
            this.ColTelefon,
            this.ColAdresa,
            this.ColGrupa,
            this.ColAnStudiu,
            this.ColSpecialitate,
            this.colFacultate});
            this.dataGridDate.EnableHeadersVisualStyles = false;
            this.dataGridDate.Location = new System.Drawing.Point(0, 106);
            this.dataGridDate.Name = "dataGridDate";
            this.dataGridDate.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDate.RowHeadersVisible = false;
            this.dataGridDate.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridDate.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDate.RowTemplate.Height = 28;
            this.dataGridDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDate.Size = new System.Drawing.Size(1077, 500);
            this.dataGridDate.TabIndex = 21;
            this.dataGridDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDate_CellContentClick);
            // 
            // comboBoxGrupe
            // 
            this.comboBoxGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxGrupe.FormattingEnabled = true;
            this.comboBoxGrupe.Location = new System.Drawing.Point(12, 76);
            this.comboBoxGrupe.Name = "comboBoxGrupe";
            this.comboBoxGrupe.Size = new System.Drawing.Size(130, 24);
            this.comboBoxGrupe.TabIndex = 22;
            this.comboBoxGrupe.Text = "             Grupe";
            this.comboBoxGrupe.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupe_SelectedIndexChanged);
            // 
            // labelGrupa
            // 
            this.labelGrupa.AutoSize = true;
            this.labelGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGrupa.ForeColor = System.Drawing.Color.Transparent;
            this.labelGrupa.Location = new System.Drawing.Point(12, 57);
            this.labelGrupa.Name = "labelGrupa";
            this.labelGrupa.Size = new System.Drawing.Size(47, 16);
            this.labelGrupa.TabIndex = 23;
            this.labelGrupa.Text = "Grupa:";
            // 
            // labelAnStudiu
            // 
            this.labelAnStudiu.AutoSize = true;
            this.labelAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnStudiu.ForeColor = System.Drawing.Color.Transparent;
            this.labelAnStudiu.Location = new System.Drawing.Point(164, 57);
            this.labelAnStudiu.Name = "labelAnStudiu";
            this.labelAnStudiu.Size = new System.Drawing.Size(66, 16);
            this.labelAnStudiu.TabIndex = 25;
            this.labelAnStudiu.Text = "An Studiu:";
            this.labelAnStudiu.Click += new System.EventHandler(this.labelAnStudiu_Click);
            // 
            // comboBoxAnStudiu
            // 
            this.comboBoxAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAnStudiu.FormattingEnabled = true;
            this.comboBoxAnStudiu.Location = new System.Drawing.Point(164, 76);
            this.comboBoxAnStudiu.Name = "comboBoxAnStudiu";
            this.comboBoxAnStudiu.Size = new System.Drawing.Size(130, 24);
            this.comboBoxAnStudiu.TabIndex = 24;
            this.comboBoxAnStudiu.Text = "          An Studiu";
            this.comboBoxAnStudiu.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnStudiu_SelectedIndexChanged);
            // 
            // labelSpecialitate
            // 
            this.labelSpecialitate.AutoSize = true;
            this.labelSpecialitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpecialitate.ForeColor = System.Drawing.Color.Transparent;
            this.labelSpecialitate.Location = new System.Drawing.Point(317, 57);
            this.labelSpecialitate.Name = "labelSpecialitate";
            this.labelSpecialitate.Size = new System.Drawing.Size(81, 16);
            this.labelSpecialitate.TabIndex = 27;
            this.labelSpecialitate.Text = "Specialitate:";
            this.labelSpecialitate.Click += new System.EventHandler(this.labelSpecialitate_Click);
            // 
            // comboBoxSpecialitate
            // 
            this.comboBoxSpecialitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecialitate.FormattingEnabled = true;
            this.comboBoxSpecialitate.Location = new System.Drawing.Point(317, 76);
            this.comboBoxSpecialitate.Name = "comboBoxSpecialitate";
            this.comboBoxSpecialitate.Size = new System.Drawing.Size(130, 24);
            this.comboBoxSpecialitate.TabIndex = 26;
            this.comboBoxSpecialitate.Text = "        Specialitate";
            this.comboBoxSpecialitate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecialitate_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelError.Location = new System.Drawing.Point(873, 76);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 29;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNume.Location = new System.Drawing.Point(471, 76);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(125, 24);
            this.textBoxNume.TabIndex = 30;
            // 
            // labelNumeSearch
            // 
            this.labelNumeSearch.AutoSize = true;
            this.labelNumeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumeSearch.ForeColor = System.Drawing.Color.Transparent;
            this.labelNumeSearch.Location = new System.Drawing.Point(468, 57);
            this.labelNumeSearch.Name = "labelNumeSearch";
            this.labelNumeSearch.Size = new System.Drawing.Size(104, 16);
            this.labelNumeSearch.TabIndex = 31;
            this.labelNumeSearch.Text = "Nume/Prenume:";
            // 
            // labelNrTotalText
            // 
            this.labelNrTotalText.AutoSize = true;
            this.labelNrTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrTotalText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNrTotalText.Location = new System.Drawing.Point(951, 79);
            this.labelNrTotalText.Name = "labelNrTotalText";
            this.labelNrTotalText.Size = new System.Drawing.Size(93, 18);
            this.labelNrTotalText.TabIndex = 33;
            this.labelNrTotalText.Text = "Numar total: ";
            // 
            // labelNumar
            // 
            this.labelNumar.AutoSize = true;
            this.labelNumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumar.Location = new System.Drawing.Point(1039, 79);
            this.labelNumar.Name = "labelNumar";
            this.labelNumar.Size = new System.Drawing.Size(16, 18);
            this.labelNumar.TabIndex = 34;
            this.labelNumar.Text = "0";
            this.labelNumar.Click += new System.EventHandler(this.labelNumar_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 0;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(935, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 40);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Șterge";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // butonModifica
            // 
            this.butonModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.butonModifica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.butonModifica.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.butonModifica.BorderRadius = 0;
            this.butonModifica.BorderSize = 0;
            this.butonModifica.FlatAppearance.BorderSize = 0;
            this.butonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonModifica.ForeColor = System.Drawing.Color.White;
            this.butonModifica.Location = new System.Drawing.Point(164, 12);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(130, 40);
            this.butonModifica.TabIndex = 36;
            this.butonModifica.Text = "Modifica";
            this.butonModifica.TextColor = System.Drawing.Color.White;
            this.butonModifica.UseVisualStyleBackColor = false;
            this.butonModifica.Click += new System.EventHandler(this.butonModifica_Click);
            // 
            // adaugaButton
            // 
            this.adaugaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.adaugaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.adaugaButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adaugaButton.BorderRadius = 0;
            this.adaugaButton.BorderSize = 0;
            this.adaugaButton.FlatAppearance.BorderSize = 0;
            this.adaugaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugaButton.ForeColor = System.Drawing.Color.White;
            this.adaugaButton.Location = new System.Drawing.Point(12, 12);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(130, 40);
            this.adaugaButton.TabIndex = 35;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.TextColor = System.Drawing.Color.White;
            this.adaugaButton.UseVisualStyleBackColor = false;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.resetButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.resetButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.resetButton.BorderRadius = 0;
            this.resetButton.BorderSize = 0;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(724, 75);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 24);
            this.resetButton.TabIndex = 32;
            this.resetButton.Text = "Reset";
            this.resetButton.TextColor = System.Drawing.Color.White;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.searchButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.searchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchButton.BorderRadius = 0;
            this.searchButton.BorderSize = 0;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(623, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 24);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Caută";
            this.searchButton.TextColor = System.Drawing.Color.White;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 55;
            // 
            // ColCNP
            // 
            this.ColCNP.HeaderText = "CNP";
            this.ColCNP.Name = "ColCNP";
            this.ColCNP.ReadOnly = true;
            this.ColCNP.Width = 120;
            // 
            // ColNume
            // 
            this.ColNume.HeaderText = "Nume";
            this.ColNume.Name = "ColNume";
            this.ColNume.ReadOnly = true;
            this.ColNume.Width = 112;
            // 
            // ColPrenume
            // 
            this.ColPrenume.HeaderText = "Prenume";
            this.ColPrenume.Name = "ColPrenume";
            this.ColPrenume.ReadOnly = true;
            this.ColPrenume.Width = 120;
            // 
            // ColNastere
            // 
            this.ColNastere.HeaderText = "Data nastere";
            this.ColNastere.Name = "ColNastere";
            this.ColNastere.ReadOnly = true;
            this.ColNastere.Width = 120;
            // 
            // ColTelefon
            // 
            this.ColTelefon.HeaderText = "Telefon";
            this.ColTelefon.Name = "ColTelefon";
            this.ColTelefon.ReadOnly = true;
            // 
            // ColAdresa
            // 
            this.ColAdresa.HeaderText = "Adresa";
            this.ColAdresa.Name = "ColAdresa";
            this.ColAdresa.ReadOnly = true;
            // 
            // ColGrupa
            // 
            this.ColGrupa.HeaderText = "Grupa";
            this.ColGrupa.Name = "ColGrupa";
            this.ColGrupa.ReadOnly = true;
            this.ColGrupa.Width = 70;
            // 
            // ColAnStudiu
            // 
            this.ColAnStudiu.HeaderText = "An Studiu";
            this.ColAnStudiu.Name = "ColAnStudiu";
            this.ColAnStudiu.ReadOnly = true;
            this.ColAnStudiu.Width = 70;
            // 
            // ColSpecialitate
            // 
            this.ColSpecialitate.HeaderText = "Specialitate";
            this.ColSpecialitate.Name = "ColSpecialitate";
            this.ColSpecialitate.ReadOnly = true;
            this.ColSpecialitate.Width = 110;
            // 
            // colFacultate
            // 
            this.colFacultate.HeaderText = "Facultate";
            this.colFacultate.Name = "colFacultate";
            this.colFacultate.ReadOnly = true;
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFacultate.ForeColor = System.Drawing.Color.Transparent;
            this.labelFacultate.Location = new System.Drawing.Point(317, 11);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(65, 16);
            this.labelFacultate.TabIndex = 39;
            this.labelFacultate.Text = "Facultate:";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.Location = new System.Drawing.Point(317, 30);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(130, 24);
            this.comboBoxFacultate.TabIndex = 38;
            this.comboBoxFacultate.Text = "          Facultate";
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1077, 606);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(this.labelFacultate);
            this.Controls.Add(this.comboBoxFacultate);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.labelNumar);
            this.Controls.Add(this.labelNrTotalText);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.labelNumeSearch);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labelSpecialitate);
            this.Controls.Add(this.comboBoxSpecialitate);
            this.Controls.Add(this.labelAnStudiu);
            this.Controls.Add(this.comboBoxAnStudiu);
            this.Controls.Add(this.labelGrupa);
            this.Controls.Add(this.comboBoxGrupe);
            this.Controls.Add(this.dataGridDate);
           
            this.Name = "StudentiForm";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDate;
        private System.Windows.Forms.ComboBox comboBoxGrupe;
        private System.Windows.Forms.Label labelGrupa;
        private System.Windows.Forms.Label labelAnStudiu;
        private System.Windows.Forms.ComboBox comboBoxAnStudiu;
        private System.Windows.Forms.Label labelSpecialitate;
        private System.Windows.Forms.ComboBox comboBoxSpecialitate;
        private Butoane.RJButton searchButton;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNumeSearch;
        private Butoane.RJButton resetButton;
        private System.Windows.Forms.Label labelNrTotalText;
        private System.Windows.Forms.Label labelNumar;
        private Butoane.RJButton adaugaButton;
        private Butoane.RJButton butonModifica;
        private Butoane.RJButton deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNastere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnStudiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSpecialitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultate;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
    }
}