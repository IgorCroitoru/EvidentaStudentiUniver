namespace EvidentaStudenti
{
    partial class ModificaFacultateForm
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
            this.butonModifica = new EvidentaStudenti.Butoane.RJButton();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.textBoxAbreviere = new System.Windows.Forms.TextBox();
            this.labelAbreviere = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAdauga = new EvidentaStudenti.Butoane.RJButton();
            this.labelSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
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
            this.butonModifica.Location = new System.Drawing.Point(23, 154);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(130, 40);
            this.butonModifica.TabIndex = 46;
            this.butonModifica.Text = "Modifica";
            this.butonModifica.TextColor = System.Drawing.Color.White;
            this.butonModifica.UseVisualStyleBackColor = false;
            this.butonModifica.Click += new System.EventHandler(this.butonModifica_Click);
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(23, 50);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(155, 20);
            this.textBoxNume.TabIndex = 45;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNume.Location = new System.Drawing.Point(20, 29);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(52, 18);
            this.labelNume.TabIndex = 44;
            this.labelNume.Text = "Nume:";
            // 
            // textBoxAbreviere
            // 
            this.textBoxAbreviere.Location = new System.Drawing.Point(23, 107);
            this.textBoxAbreviere.Name = "textBoxAbreviere";
            this.textBoxAbreviere.Size = new System.Drawing.Size(155, 20);
            this.textBoxAbreviere.TabIndex = 48;
            this.textBoxAbreviere.TextChanged += new System.EventHandler(this.textBoxAbreviere_TextChanged);
            // 
            // labelAbreviere
            // 
            this.labelAbreviere.AutoSize = true;
            this.labelAbreviere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAbreviere.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAbreviere.Location = new System.Drawing.Point(20, 86);
            this.labelAbreviere.Name = "labelAbreviere";
            this.labelAbreviere.Size = new System.Drawing.Size(73, 18);
            this.labelAbreviere.TabIndex = 47;
            this.labelAbreviere.Text = "Abreviere:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            this.buttonAdauga.Location = new System.Drawing.Point(23, 154);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(130, 40);
            this.buttonAdauga.TabIndex = 49;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.TextColor = System.Drawing.Color.White;
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccess.Location = new System.Drawing.Point(20, 209);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 16);
            this.labelSuccess.TabIndex = 50;
            // 
            // ModificaFacultateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(243, 252);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxAbreviere);
            this.Controls.Add(this.labelAbreviere);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Name = "ModificaFacultateForm";
            this.Text = "Modifica Facultate";
            this.Load += new System.EventHandler(this.ModificaFacultateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Butoane.RJButton butonModifica;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox textBoxAbreviere;
        private System.Windows.Forms.Label labelAbreviere;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Butoane.RJButton buttonAdauga;
        private System.Windows.Forms.Label labelSuccess;
    }
}