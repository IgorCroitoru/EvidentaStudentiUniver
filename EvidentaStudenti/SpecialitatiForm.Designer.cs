namespace EvidentaStudenti
{
    partial class SpecialitatiForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridSpec = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrGrupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrStudenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.deleteButton = new EvidentaStudenti.Butoane.RJButton();
            this.butonModifica = new EvidentaStudenti.Butoane.RJButton();
            this.adaugaButton = new EvidentaStudenti.Butoane.RJButton();
            this.resetButton = new EvidentaStudenti.Butoane.RJButton();
            this.labelModificare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSpec
            // 
            this.dataGridSpec.AllowUserToAddRows = false;
            this.dataGridSpec.AllowUserToDeleteRows = false;
            this.dataGridSpec.AllowUserToOrderColumns = true;
            this.dataGridSpec.AllowUserToResizeColumns = false;
            this.dataGridSpec.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridSpec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSpec.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridSpec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSpec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridSpec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSpec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colNume,
            this.colFacultate,
            this.colNrGrupe,
            this.colNrStudenti});
            this.dataGridSpec.EnableHeadersVisualStyles = false;
            this.dataGridSpec.Location = new System.Drawing.Point(0, 83);
            this.dataGridSpec.Name = "dataGridSpec";
            this.dataGridSpec.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSpec.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridSpec.RowHeadersVisible = false;
            this.dataGridSpec.RowHeadersWidth = 20;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridSpec.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridSpec.RowTemplate.Height = 28;
            this.dataGridSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpec.Size = new System.Drawing.Size(735, 521);
            this.dataGridSpec.TabIndex = 23;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 55;
            // 
            // colNume
            // 
            this.colNume.HeaderText = "Nume";
            this.colNume.Name = "colNume";
            this.colNume.ReadOnly = true;
            this.colNume.Width = 150;
            // 
            // colFacultate
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colFacultate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFacultate.HeaderText = "Facultate";
            this.colFacultate.Name = "colFacultate";
            this.colFacultate.ReadOnly = true;
            this.colFacultate.Width = 300;
            // 
            // colNrGrupe
            // 
            this.colNrGrupe.HeaderText = "Numar Grupe";
            this.colNrGrupe.Name = "colNrGrupe";
            this.colNrGrupe.ReadOnly = true;
            this.colNrGrupe.Width = 130;
            // 
            // colNrStudenti
            // 
            this.colNrStudenti.HeaderText = "Numar studenti";
            this.colNrStudenti.Name = "colNrStudenti";
            this.colNrStudenti.ReadOnly = true;
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFacultate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFacultate.Location = new System.Drawing.Point(826, 159);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(72, 18);
            this.labelFacultate.TabIndex = 42;
            this.labelFacultate.Text = "Facultate:";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.Location = new System.Drawing.Point(829, 180);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFacultate.TabIndex = 41;
            this.comboBoxFacultate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultate_SelectedIndexChanged);
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(829, 125);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(155, 20);
            this.textBoxNume.TabIndex = 40;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNume.Location = new System.Drawing.Point(826, 104);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(52, 18);
            this.labelNume.TabIndex = 39;
            this.labelNume.Text = "Nume:";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccess.Location = new System.Drawing.Point(826, 284);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 16);
            this.labelSuccess.TabIndex = 43;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            this.deleteButton.Location = new System.Drawing.Point(172, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 40);
            this.deleteButton.TabIndex = 44;
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
            this.butonModifica.Location = new System.Drawing.Point(12, 28);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(130, 40);
            this.butonModifica.TabIndex = 38;
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
            this.adaugaButton.Location = new System.Drawing.Point(829, 219);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(130, 40);
            this.adaugaButton.TabIndex = 37;
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
            this.resetButton.Location = new System.Drawing.Point(649, 44);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 24);
            this.resetButton.TabIndex = 45;
            this.resetButton.Text = "Reset";
            this.resetButton.TextColor = System.Drawing.Color.White;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // labelModificare
            // 
            this.labelModificare.AutoSize = true;
            this.labelModificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModificare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelModificare.Location = new System.Drawing.Point(825, 41);
            this.labelModificare.Name = "labelModificare";
            this.labelModificare.Size = new System.Drawing.Size(195, 24);
            this.labelModificare.TabIndex = 46;
            this.labelModificare.Text = "Adaugare specialitate:";
            // 
            // SpecialitatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1077, 606);
            this.Controls.Add(this.labelModificare);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.labelFacultate);
            this.Controls.Add(this.comboBoxFacultate);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.dataGridSpec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpecialitatiForm";
            this.Text = "Specialitati";
            this.Load += new System.EventHandler(this.SpecialitatiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSpec;
        private Butoane.RJButton butonModifica;
        private Butoane.RJButton adaugaButton;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrStudenti;
        private Butoane.RJButton deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Butoane.RJButton resetButton;
        private System.Windows.Forms.Label labelModificare;
    }
}