namespace EvidentaStudenti
{
    partial class Form1
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
            this.panelSus = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.PictureBox();
            this.acasaText = new System.Windows.Forms.Label();
            this.panouStanga = new System.Windows.Forms.Panel();
            this.buttonSpecialitate = new System.Windows.Forms.Button();
            this.buttonGrupe = new System.Windows.Forms.Button();
            this.panouLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStudenti = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.buttonFacultati = new System.Windows.Forms.Button();
            this.panelSus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).BeginInit();
            this.panouStanga.SuspendLayout();
            this.panouLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSus
            // 
            this.panelSus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelSus.Controls.Add(this.btnCloseChildForm);
            this.panelSus.Controls.Add(this.acasaText);
            this.panelSus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSus.Location = new System.Drawing.Point(0, 0);
            this.panelSus.Name = "panelSus";
            this.panelSus.Size = new System.Drawing.Size(1206, 72);
            this.panelSus.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Image = global::EvidentaStudenti.Properties.Resources._4177409791543238955_1281;
            this.btnCloseChildForm.Location = new System.Drawing.Point(134, 19);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(22, 20);
            this.btnCloseChildForm.TabIndex = 0;
            this.btnCloseChildForm.TabStop = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // acasaText
            // 
            this.acasaText.AutoSize = true;
            this.acasaText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.acasaText.ForeColor = System.Drawing.SystemColors.Control;
            this.acasaText.Location = new System.Drawing.Point(613, 19);
            this.acasaText.Name = "acasaText";
            this.acasaText.Size = new System.Drawing.Size(91, 37);
            this.acasaText.TabIndex = 3;
            this.acasaText.Text = "Acasa";
            this.acasaText.Click += new System.EventHandler(this.acasaText_Click);
            // 
            // panouStanga
            // 
            this.panouStanga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panouStanga.Controls.Add(this.buttonFacultati);
            this.panouStanga.Controls.Add(this.buttonSpecialitate);
            this.panouStanga.Controls.Add(this.buttonGrupe);
            this.panouStanga.Controls.Add(this.panouLogo);
            this.panouStanga.Controls.Add(this.buttonStudenti);
            this.panouStanga.Location = new System.Drawing.Point(0, 0);
            this.panouStanga.Name = "panouStanga";
            this.panouStanga.Size = new System.Drawing.Size(128, 681);
            this.panouStanga.TabIndex = 0;
            // 
            // buttonSpecialitate
            // 
            this.buttonSpecialitate.FlatAppearance.BorderSize = 0;
            this.buttonSpecialitate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpecialitate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSpecialitate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSpecialitate.Location = new System.Drawing.Point(0, 164);
            this.buttonSpecialitate.Name = "buttonSpecialitate";
            this.buttonSpecialitate.Size = new System.Drawing.Size(128, 46);
            this.buttonSpecialitate.TabIndex = 3;
            this.buttonSpecialitate.Text = "Specialitati";
            this.buttonSpecialitate.UseVisualStyleBackColor = true;
            this.buttonSpecialitate.Click += new System.EventHandler(this.buttonSpecialitate_Click);
            // 
            // buttonGrupe
            // 
            this.buttonGrupe.FlatAppearance.BorderSize = 0;
            this.buttonGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrupe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonGrupe.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGrupe.Location = new System.Drawing.Point(0, 118);
            this.buttonGrupe.Name = "buttonGrupe";
            this.buttonGrupe.Size = new System.Drawing.Size(128, 46);
            this.buttonGrupe.TabIndex = 2;
            this.buttonGrupe.Text = "Grupe";
            this.buttonGrupe.UseVisualStyleBackColor = true;
            this.buttonGrupe.Click += new System.EventHandler(this.buttonGrupe_Click);
            // 
            // panouLogo
            // 
            this.panouLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panouLogo.Controls.Add(this.label1);
            this.panouLogo.Location = new System.Drawing.Point(0, 0);
            this.panouLogo.Name = "panouLogo";
            this.panouLogo.Size = new System.Drawing.Size(128, 72);
            this.panouLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidenta\r\nStudenti";
            // 
            // buttonStudenti
            // 
            this.buttonStudenti.FlatAppearance.BorderSize = 0;
            this.buttonStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudenti.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonStudenti.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStudenti.Location = new System.Drawing.Point(0, 72);
            this.buttonStudenti.Name = "buttonStudenti";
            this.buttonStudenti.Size = new System.Drawing.Size(128, 46);
            this.buttonStudenti.TabIndex = 1;
            this.buttonStudenti.Text = "Studenti";
            this.buttonStudenti.UseVisualStyleBackColor = true;
            this.buttonStudenti.Click += new System.EventHandler(this.buttonStudenti_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDesktop.Location = new System.Drawing.Point(128, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1078, 609);
            this.panelDesktop.TabIndex = 2;
            // 
            // buttonFacultati
            // 
            this.buttonFacultati.FlatAppearance.BorderSize = 0;
            this.buttonFacultati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacultati.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonFacultati.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonFacultati.Location = new System.Drawing.Point(0, 210);
            this.buttonFacultati.Name = "buttonFacultati";
            this.buttonFacultati.Size = new System.Drawing.Size(128, 46);
            this.buttonFacultati.TabIndex = 4;
            this.buttonFacultati.Text = "Facultati";
            this.buttonFacultati.UseVisualStyleBackColor = true;
            this.buttonFacultati.Click += new System.EventHandler(this.buttonFacultati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 681);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panouStanga);
            this.Controls.Add(this.panelSus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelSus.ResumeLayout(false);
            this.panelSus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseChildForm)).EndInit();
            this.panouStanga.ResumeLayout(false);
            this.panouLogo.ResumeLayout(false);
            this.panouLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSus;
        private System.Windows.Forms.Panel panouStanga;
        private System.Windows.Forms.Panel panouLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStudenti;
        private System.Windows.Forms.Label acasaText;
        private System.Windows.Forms.Button buttonGrupe;
        private System.Windows.Forms.PictureBox btnCloseChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonSpecialitate;
        private System.Windows.Forms.Button buttonFacultati;
    }
}

