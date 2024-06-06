namespace EvidentaStudenti
{
    partial class FacultateForm
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
            this.dataGridFacultate = new System.Windows.Forms.DataGridView();
            this.deleteButton = new EvidentaStudenti.Butoane.RJButton();
            this.adaugaButton = new EvidentaStudenti.Butoane.RJButton();
            this.buttonModifica = new EvidentaStudenti.Butoane.RJButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbreviere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrStudenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrGrupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacultate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFacultate
            // 
            this.dataGridFacultate.AllowUserToAddRows = false;
            this.dataGridFacultate.AllowUserToDeleteRows = false;
            this.dataGridFacultate.AllowUserToOrderColumns = true;
            this.dataGridFacultate.AllowUserToResizeColumns = false;
            this.dataGridFacultate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridFacultate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFacultate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFacultate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFacultate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridFacultate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFacultate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFacultate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacultate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colNume,
            this.colAbreviere,
            this.colNrStudenti,
            this.colNrGrupe,
            this.colNrSpec});
            this.dataGridFacultate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridFacultate.EnableHeadersVisualStyles = false;
            this.dataGridFacultate.Location = new System.Drawing.Point(0, 110);
            this.dataGridFacultate.Name = "dataGridFacultate";
            this.dataGridFacultate.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFacultate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridFacultate.RowHeadersVisible = false;
            this.dataGridFacultate.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridFacultate.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFacultate.RowTemplate.Height = 28;
            this.dataGridFacultate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacultate.Size = new System.Drawing.Size(1077, 496);
            this.dataGridFacultate.TabIndex = 23;
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
            this.deleteButton.Location = new System.Drawing.Point(935, 48);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 40);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Șterge";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.adaugaButton.Location = new System.Drawing.Point(12, 48);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(130, 40);
            this.adaugaButton.TabIndex = 39;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.TextColor = System.Drawing.Color.White;
            this.adaugaButton.UseVisualStyleBackColor = false;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonModifica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonModifica.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonModifica.BorderRadius = 0;
            this.buttonModifica.BorderSize = 0;
            this.buttonModifica.FlatAppearance.BorderSize = 0;
            this.buttonModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifica.ForeColor = System.Drawing.Color.White;
            this.buttonModifica.Location = new System.Drawing.Point(170, 48);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(130, 40);
            this.buttonModifica.TabIndex = 41;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.TextColor = System.Drawing.Color.White;
            this.buttonModifica.UseVisualStyleBackColor = false;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // colNume
            // 
            this.colNume.HeaderText = "Nume";
            this.colNume.Name = "colNume";
            this.colNume.ReadOnly = true;
            this.colNume.Width = 350;
            // 
            // colAbreviere
            // 
            this.colAbreviere.HeaderText = "Abreviere";
            this.colAbreviere.Name = "colAbreviere";
            this.colAbreviere.ReadOnly = true;
            this.colAbreviere.Width = 160;
            // 
            // colNrStudenti
            // 
            this.colNrStudenti.HeaderText = "Numar studenti";
            this.colNrStudenti.Name = "colNrStudenti";
            this.colNrStudenti.ReadOnly = true;
            this.colNrStudenti.Width = 162;
            // 
            // colNrGrupe
            // 
            this.colNrGrupe.HeaderText = "Numar Grupe";
            this.colNrGrupe.Name = "colNrGrupe";
            this.colNrGrupe.ReadOnly = true;
            this.colNrGrupe.Width = 160;
            // 
            // colNrSpec
            // 
            this.colNrSpec.HeaderText = "Numar Specialitati";
            this.colNrSpec.Name = "colNrSpec";
            this.colNrSpec.ReadOnly = true;
            this.colNrSpec.Width = 171;
            // 
            // FacultateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1077, 606);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.dataGridFacultate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacultateForm";
            this.Text = "Facultati";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacultate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFacultate;
        private Butoane.RJButton deleteButton;
        private Butoane.RJButton adaugaButton;
        private Butoane.RJButton buttonModifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbreviere;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrSpec;
    }
}