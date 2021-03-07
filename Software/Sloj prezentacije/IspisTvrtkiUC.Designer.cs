namespace TransportApp.Sloj_prezentacije
{
    partial class IspisTvrtkiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTvrtke = new System.Windows.Forms.DataGridView();
            this.panelRutaMeni = new System.Windows.Forms.Panel();
            this.btnAzirirajTvrtku = new System.Windows.Forms.Button();
            this.btnKreirajTvrtku = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblKorisnickoImeValue = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblLozinkaValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTvrtke)).BeginInit();
            this.panelRutaMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTvrtke
            // 
            this.dgvTvrtke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTvrtke.ColumnHeadersHeight = 29;
            this.dgvTvrtke.Location = new System.Drawing.Point(22, 23);
            this.dgvTvrtke.Name = "dgvTvrtke";
            this.dgvTvrtke.RowHeadersWidth = 51;
            this.dgvTvrtke.RowTemplate.Height = 24;
            this.dgvTvrtke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTvrtke.Size = new System.Drawing.Size(903, 681);
            this.dgvTvrtke.TabIndex = 1;
            this.dgvTvrtke.SelectionChanged += new System.EventHandler(this.dgvTvrtke_SelectionChanged);
            // 
            // panelRutaMeni
            // 
            this.panelRutaMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelRutaMeni.Controls.Add(this.btnAzirirajTvrtku);
            this.panelRutaMeni.Controls.Add(this.btnKreirajTvrtku);
            this.panelRutaMeni.Location = new System.Drawing.Point(0, 724);
            this.panelRutaMeni.Name = "panelRutaMeni";
            this.panelRutaMeni.Size = new System.Drawing.Size(1277, 86);
            this.panelRutaMeni.TabIndex = 2;
            // 
            // btnAzirirajTvrtku
            // 
            this.btnAzirirajTvrtku.FlatAppearance.BorderSize = 0;
            this.btnAzirirajTvrtku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzirirajTvrtku.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAzirirajTvrtku.ForeColor = System.Drawing.Color.White;
            this.btnAzirirajTvrtku.Location = new System.Drawing.Point(666, 8);
            this.btnAzirirajTvrtku.Name = "btnAzirirajTvrtku";
            this.btnAzirirajTvrtku.Size = new System.Drawing.Size(209, 75);
            this.btnAzirirajTvrtku.TabIndex = 7;
            this.btnAzirirajTvrtku.Text = "Ažuriraj tvrtku";
            this.btnAzirirajTvrtku.UseVisualStyleBackColor = true;
            this.btnAzirirajTvrtku.Click += new System.EventHandler(this.btnAzirirajTvrtku_Click);
            // 
            // btnKreirajTvrtku
            // 
            this.btnKreirajTvrtku.FlatAppearance.BorderSize = 0;
            this.btnKreirajTvrtku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajTvrtku.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnKreirajTvrtku.ForeColor = System.Drawing.Color.White;
            this.btnKreirajTvrtku.Location = new System.Drawing.Point(451, 8);
            this.btnKreirajTvrtku.Name = "btnKreirajTvrtku";
            this.btnKreirajTvrtku.Size = new System.Drawing.Size(209, 75);
            this.btnKreirajTvrtku.TabIndex = 6;
            this.btnKreirajTvrtku.Text = "Kreiraj tvrtku";
            this.btnKreirajTvrtku.UseVisualStyleBackColor = true;
            this.btnKreirajTvrtku.Click += new System.EventHandler(this.btnKreirajTvrtku_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(944, 51);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(174, 29);
            this.lblAdministrator.TabIndex = 3;
            this.lblAdministrator.Text = "Administrator:";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrator.Location = new System.Drawing.Point(949, 94);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(169, 61);
            this.btnAdministrator.TabIndex = 4;
            this.btnAdministrator.Text = "Dodijeli administratora";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(944, 94);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(145, 25);
            this.lblKorisnickoIme.TabIndex = 5;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblKorisnickoImeValue
            // 
            this.lblKorisnickoImeValue.AutoSize = true;
            this.lblKorisnickoImeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoImeValue.Location = new System.Drawing.Point(944, 132);
            this.lblKorisnickoImeValue.Name = "lblKorisnickoImeValue";
            this.lblKorisnickoImeValue.Size = new System.Drawing.Size(18, 25);
            this.lblKorisnickoImeValue.TabIndex = 5;
            this.lblKorisnickoImeValue.Text = "/";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(944, 172);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(86, 25);
            this.lblLozinka.TabIndex = 5;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblLozinkaValue
            // 
            this.lblLozinkaValue.AutoSize = true;
            this.lblLozinkaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinkaValue.Location = new System.Drawing.Point(944, 212);
            this.lblLozinkaValue.Name = "lblLozinkaValue";
            this.lblLozinkaValue.Size = new System.Drawing.Size(18, 25);
            this.lblLozinkaValue.TabIndex = 5;
            this.lblLozinkaValue.Text = "/";
            // 
            // IspisTvrtkiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLozinkaValue);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoImeValue);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.panelRutaMeni);
            this.Controls.Add(this.dgvTvrtke);
            this.Name = "IspisTvrtkiUC";
            this.Size = new System.Drawing.Size(1277, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTvrtke)).EndInit();
            this.panelRutaMeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTvrtke;
        private System.Windows.Forms.Panel panelRutaMeni;
        private System.Windows.Forms.Button btnAzirirajTvrtku;
        private System.Windows.Forms.Button btnKreirajTvrtku;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoImeValue;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblLozinkaValue;
    }
}
