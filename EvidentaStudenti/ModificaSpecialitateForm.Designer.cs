namespace EvidentaStudenti
{
    partial class ModificaSpecialitateForm
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
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.butonModifica = new EvidentaStudenti.Butoane.RJButton();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(27, 55);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(155, 20);
            this.textBoxNume.TabIndex = 42;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNume.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNume.Location = new System.Drawing.Point(24, 34);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(52, 18);
            this.labelNume.TabIndex = 41;
            this.labelNume.Text = "Nume:";
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
            this.butonModifica.Location = new System.Drawing.Point(27, 94);
            this.butonModifica.Name = "butonModifica";
            this.butonModifica.Size = new System.Drawing.Size(130, 40);
            this.butonModifica.TabIndex = 43;
            this.butonModifica.Text = "Modifica";
            this.butonModifica.TextColor = System.Drawing.Color.White;
            this.butonModifica.UseVisualStyleBackColor = false;
            this.butonModifica.Click += new System.EventHandler(this.butonModifica_Click);
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSuccess.Location = new System.Drawing.Point(24, 156);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 16);
            this.labelSuccess.TabIndex = 44;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificaSpecialitateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(243, 252);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.butonModifica);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Name = "ModificaSpecialitateForm";
            this.Text = "ModificaSpecialitateForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private Butoane.RJButton butonModifica;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}