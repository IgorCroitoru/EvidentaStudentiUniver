namespace EvidentaStudenti
{
    partial class GrupeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridGrupe = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnStudiu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNrStudenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSpecialitate = new System.Windows.Forms.Label();
            this.comboBoxSpecialitate = new System.Windows.Forms.ComboBox();
            this.labelAnStudiu = new System.Windows.Forms.Label();
            this.comboBoxAnStudiu = new System.Windows.Forms.ComboBox();
            this.resetButton = new EvidentaStudenti.Butoane.RJButton();
            this.searchButton = new EvidentaStudenti.Butoane.RJButton();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.adaugaButton = new EvidentaStudenti.Butoane.RJButton();
            this.deleteButton = new EvidentaStudenti.Butoane.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGrupe
            // 
            this.dataGridGrupe.AllowUserToAddRows = false;
            this.dataGridGrupe.AllowUserToDeleteRows = false;
            this.dataGridGrupe.AllowUserToOrderColumns = true;
            this.dataGridGrupe.AllowUserToResizeColumns = false;
            this.dataGridGrupe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridGrupe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGrupe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridGrupe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGrupe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridGrupe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGrupe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colNume,
            this.colSpecialitate,
            this.colAnStudiu,
            this.colNrStudenti,
            this.colFacultate});
            this.dataGridGrupe.EnableHeadersVisualStyles = false;
            this.dataGridGrupe.Location = new System.Drawing.Point(0, 107);
            this.dataGridGrupe.Name = "dataGridGrupe";
            this.dataGridGrupe.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGrupe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridGrupe.RowHeadersVisible = false;
            this.dataGridGrupe.RowHeadersWidth = 20;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(227)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridGrupe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridGrupe.RowTemplate.Height = 28;
            this.dataGridGrupe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGrupe.Size = new System.Drawing.Size(605, 496);
            this.dataGridGrupe.TabIndex = 22;
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
            // 
            // colSpecialitate
            // 
            this.colSpecialitate.HeaderText = "Specialitate";
            this.colSpecialitate.Name = "colSpecialitate";
            this.colSpecialitate.ReadOnly = true;
            this.colSpecialitate.Width = 150;
            // 
            // colAnStudiu
            // 
            this.colAnStudiu.HeaderText = "An studiu";
            this.colAnStudiu.Name = "colAnStudiu";
            this.colAnStudiu.ReadOnly = true;
            // 
            // colNrStudenti
            // 
            this.colNrStudenti.HeaderText = "Numar studenti";
            this.colNrStudenti.Name = "colNrStudenti";
            this.colNrStudenti.ReadOnly = true;
            // 
            // colFacultate
            // 
            this.colFacultate.HeaderText = "Facultate";
            this.colFacultate.Name = "colFacultate";
            this.colFacultate.ReadOnly = true;
            // 
            // labelSpecialitate
            // 
            this.labelSpecialitate.AutoSize = true;
            this.labelSpecialitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpecialitate.ForeColor = System.Drawing.Color.Transparent;
            this.labelSpecialitate.Location = new System.Drawing.Point(166, 58);
            this.labelSpecialitate.Name = "labelSpecialitate";
            this.labelSpecialitate.Size = new System.Drawing.Size(81, 16);
            this.labelSpecialitate.TabIndex = 31;
            this.labelSpecialitate.Text = "Specialitate:";
            // 
            // comboBoxSpecialitate
            // 
            this.comboBoxSpecialitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecialitate.FormattingEnabled = true;
            this.comboBoxSpecialitate.Location = new System.Drawing.Point(166, 77);
            this.comboBoxSpecialitate.Name = "comboBoxSpecialitate";
            this.comboBoxSpecialitate.Size = new System.Drawing.Size(130, 24);
            this.comboBoxSpecialitate.TabIndex = 30;
            this.comboBoxSpecialitate.Text = "        Specialitate";
            // 
            // labelAnStudiu
            // 
            this.labelAnStudiu.AutoSize = true;
            this.labelAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnStudiu.ForeColor = System.Drawing.Color.Transparent;
            this.labelAnStudiu.Location = new System.Drawing.Point(322, 58);
            this.labelAnStudiu.Name = "labelAnStudiu";
            this.labelAnStudiu.Size = new System.Drawing.Size(66, 16);
            this.labelAnStudiu.TabIndex = 29;
            this.labelAnStudiu.Text = "An Studiu:";
            // 
            // comboBoxAnStudiu
            // 
            this.comboBoxAnStudiu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxAnStudiu.FormattingEnabled = true;
            this.comboBoxAnStudiu.Location = new System.Drawing.Point(322, 77);
            this.comboBoxAnStudiu.Name = "comboBoxAnStudiu";
            this.comboBoxAnStudiu.Size = new System.Drawing.Size(130, 24);
            this.comboBoxAnStudiu.TabIndex = 28;
            this.comboBoxAnStudiu.Text = "          An Studiu";
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
            this.resetButton.Location = new System.Drawing.Point(519, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(86, 24);
            this.resetButton.TabIndex = 34;
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
            this.searchButton.Location = new System.Drawing.Point(519, 77);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 24);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Caută";
            this.searchButton.TextColor = System.Drawing.Color.White;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFacultate.ForeColor = System.Drawing.Color.Transparent;
            this.labelFacultate.Location = new System.Drawing.Point(12, 58);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(65, 16);
            this.labelFacultate.TabIndex = 36;
            this.labelFacultate.Text = "Facultate:";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.Location = new System.Drawing.Point(12, 77);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(130, 24);
            this.comboBoxFacultate.TabIndex = 35;
            this.comboBoxFacultate.Text = "          Facultate";
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
            this.adaugaButton.Location = new System.Drawing.Point(15, 12);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(130, 40);
            this.adaugaButton.TabIndex = 37;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.TextColor = System.Drawing.Color.White;
            this.adaugaButton.UseVisualStyleBackColor = false;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(166, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(130, 40);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Șterge";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GrupeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1077, 606);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.labelFacultate);
            this.Controls.Add(this.comboBoxFacultate);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labelSpecialitate);
            this.Controls.Add(this.comboBoxSpecialitate);
            this.Controls.Add(this.labelAnStudiu);
            this.Controls.Add(this.comboBoxAnStudiu);
            this.Controls.Add(this.dataGridGrupe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrupeForm";
            this.Text = "Grupe";
            this.Load += new System.EventHandler(this.GrupeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnStudiu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrStudenti;
        private System.Windows.Forms.Label labelSpecialitate;
        private System.Windows.Forms.ComboBox comboBoxSpecialitate;
        private System.Windows.Forms.Label labelAnStudiu;
        private System.Windows.Forms.ComboBox comboBoxAnStudiu;
        private Butoane.RJButton resetButton;
        private Butoane.RJButton searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultate;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private Butoane.RJButton adaugaButton;
        private Butoane.RJButton deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}