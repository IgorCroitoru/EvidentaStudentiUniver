namespace EvidentaStudenti
{
    partial class AdaugaGrupaForm
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
            this.labelFacultate = new System.Windows.Forms.Label();
            this.comboBoxFacultate = new System.Windows.Forms.ComboBox();
            this.labelAn = new System.Windows.Forms.Label();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.labelSpecialitate = new System.Windows.Forms.Label();
            this.comboBoxSpecialitate = new System.Windows.Forms.ComboBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.buttonAdauga = new EvidentaStudenti.Butoane.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFacultate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFacultate.Location = new System.Drawing.Point(12, 74);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(72, 18);
            this.labelFacultate.TabIndex = 31;
            this.labelFacultate.Text = "Facultate:";
            // 
            // comboBoxFacultate
            // 
            this.comboBoxFacultate.FormattingEnabled = true;
            this.comboBoxFacultate.Location = new System.Drawing.Point(15, 95);
            this.comboBoxFacultate.Name = "comboBoxFacultate";
            this.comboBoxFacultate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFacultate.TabIndex = 30;
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAn.Location = new System.Drawing.Point(12, 168);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(29, 18);
            this.labelAn.TabIndex = 29;
            this.labelAn.Text = "An:";
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Location = new System.Drawing.Point(15, 189);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAn.TabIndex = 28;
            // 
            // labelSpecialitate
            // 
            this.labelSpecialitate.AutoSize = true;
            this.labelSpecialitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpecialitate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSpecialitate.Location = new System.Drawing.Point(12, 123);
            this.labelSpecialitate.Name = "labelSpecialitate";
            this.labelSpecialitate.Size = new System.Drawing.Size(87, 18);
            this.labelSpecialitate.TabIndex = 27;
            this.labelSpecialitate.Text = "Specialitate:";
            // 
            // comboBoxSpecialitate
            // 
            this.comboBoxSpecialitate.FormattingEnabled = true;
            this.comboBoxSpecialitate.Location = new System.Drawing.Point(15, 144);
            this.comboBoxSpecialitate.Name = "comboBoxSpecialitate";
            this.comboBoxSpecialitate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSpecialitate.TabIndex = 26;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(15, 40);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(155, 20);
            this.textBoxNume.TabIndex = 25;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNume.Location = new System.Drawing.Point(12, 19);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(52, 18);
            this.labelNume.TabIndex = 24;
            this.labelNume.Text = "Nume:";
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonAdauga.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.buttonAdauga.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdauga.BorderRadius = 0;
            this.buttonAdauga.BorderSize = 0;
            this.buttonAdauga.FlatAppearance.BorderSize = 0;
            this.buttonAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdauga.ForeColor = System.Drawing.Color.White;
            this.buttonAdauga.Location = new System.Drawing.Point(15, 240);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(150, 40);
            this.buttonAdauga.TabIndex = 32;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.TextColor = System.Drawing.Color.White;
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccess.Location = new System.Drawing.Point(12, 301);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 16);
            this.labelSuccess.TabIndex = 33;
            // 
            // AdaugaGrupaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(243, 560);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.labelFacultate);
            this.Controls.Add(this.comboBoxFacultate);
            this.Controls.Add(this.labelAn);
            this.Controls.Add(this.comboBoxAn);
            this.Controls.Add(this.labelSpecialitate);
            this.Controls.Add(this.comboBoxSpecialitate);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Name = "AdaugaGrupaForm";
            this.Text = "AdaugaGrupaForm";
            this.Load += new System.EventHandler(this.AdaugaGrupaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.ComboBox comboBoxFacultate;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.Label labelSpecialitate;
        private System.Windows.Forms.ComboBox comboBoxSpecialitate;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private Butoane.RJButton buttonAdauga;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelSuccess;
    }
}