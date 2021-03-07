namespace TransportApp
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.panelMeni = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMeniPozicija = new System.Windows.Forms.Panel();
            this.pctBoxProfil = new System.Windows.Forms.PictureBox();
            this.btnZapisnici = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnRute = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.panelSadrzaj = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ispisTvrtkiUC1 = new TransportApp.Sloj_prezentacije.IspisTvrtkiUC();
            this.profilUC2 = new TransportApp.ProfilUC();
            this.ispisZapisnikaUC2 = new TransportApp.IspisZapisnikaUC();
            this.ispisRutaUC2 = new TransportApp.IspisRutaUC();
            this.profilUC1 = new TransportApp.ProfilUC();
            this.ispisZaposlenikaUC1 = new TransportApp.IspisZaposlenikaUC();
            this.emailUC1 = new TransportApp.EmailUC();
            this.ispisVozilaUC1 = new TransportApp.IspisVozilaUC();
            this.statistikaUC2 = new TransportApp.StatistikaUC();
            this.lblTvrka = new System.Windows.Forms.Label();
            this.panelMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxProfil)).BeginInit();
            this.panelSadrzaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelMeni.Controls.Add(this.lblTvrka);
            this.panelMeni.Controls.Add(this.lblUsername);
            this.panelMeni.Controls.Add(this.lblLogOut);
            this.panelMeni.Controls.Add(this.pctBoxLogo);
            this.panelMeni.Controls.Add(this.panelMeniPozicija);
            this.panelMeni.Controls.Add(this.pctBoxProfil);
            this.panelMeni.Controls.Add(this.btnZapisnici);
            this.panelMeni.Controls.Add(this.btnZaposlenici);
            this.panelMeni.Controls.Add(this.btnVozila);
            this.panelMeni.Controls.Add(this.btnRute);
            this.panelMeni.Controls.Add(this.btnStatistika);
            this.panelMeni.Controls.Add(this.btnEmail);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(175, 810);
            this.panelMeni.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.lblUsername, "profil");
            this.helpProvider1.SetHelpNavigator(this.lblUsername, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.lblUsername.Location = new System.Drawing.Point(38, 701);
            this.lblUsername.Name = "lblUsername";
            this.helpProvider1.SetShowHelp(this.lblUsername, true);
            this.lblUsername.Size = new System.Drawing.Size(93, 21);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(37, 771);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(102, 30);
            this.lblLogOut.TabIndex = 9;
            this.lblLogOut.Text = "Log out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pctBoxLogo
            // 
            this.helpProvider1.SetHelpKeyword(this.pctBoxLogo, "glavnaforma");
            this.helpProvider1.SetHelpNavigator(this.pctBoxLogo, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.pctBoxLogo.Image = global::TransportApp.Properties.Resources.delivery;
            this.pctBoxLogo.Location = new System.Drawing.Point(0, 3);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.helpProvider1.SetShowHelp(this.pctBoxLogo, true);
            this.pctBoxLogo.Size = new System.Drawing.Size(172, 134);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 7;
            this.pctBoxLogo.TabStop = false;
            // 
            // panelMeniPozicija
            // 
            this.panelMeniPozicija.BackColor = System.Drawing.Color.White;
            this.panelMeniPozicija.ForeColor = System.Drawing.Color.White;
            this.panelMeniPozicija.Location = new System.Drawing.Point(3, 162);
            this.panelMeniPozicija.Name = "panelMeniPozicija";
            this.panelMeniPozicija.Size = new System.Drawing.Size(17, 75);
            this.panelMeniPozicija.TabIndex = 1;
            // 
            // pctBoxProfil
            // 
            this.helpProvider1.SetHelpKeyword(this.pctBoxProfil, "profil");
            this.helpProvider1.SetHelpNavigator(this.pctBoxProfil, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.pctBoxProfil.Image = global::TransportApp.Properties.Resources.icons8_administrator_male_30;
            this.pctBoxProfil.Location = new System.Drawing.Point(42, 622);
            this.pctBoxProfil.Name = "pctBoxProfil";
            this.helpProvider1.SetShowHelp(this.pctBoxProfil, true);
            this.pctBoxProfil.Size = new System.Drawing.Size(88, 64);
            this.pctBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxProfil.TabIndex = 5;
            this.pctBoxProfil.TabStop = false;
            this.pctBoxProfil.Click += new System.EventHandler(this.pctBoxProfil_Click);
            // 
            // btnZapisnici
            // 
            this.btnZapisnici.FlatAppearance.BorderSize = 0;
            this.btnZapisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZapisnici.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnZapisnici.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnZapisnici, "zapisnik");
            this.helpProvider1.SetHelpNavigator(this.btnZapisnici, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnZapisnici.Location = new System.Drawing.Point(12, 243);
            this.btnZapisnici.Name = "btnZapisnici";
            this.helpProvider1.SetShowHelp(this.btnZapisnici, true);
            this.btnZapisnici.Size = new System.Drawing.Size(163, 75);
            this.btnZapisnici.TabIndex = 4;
            this.btnZapisnici.Text = "Zapisnici";
            this.btnZapisnici.UseVisualStyleBackColor = true;
            this.btnZapisnici.Click += new System.EventHandler(this.btnZapisnici_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatAppearance.BorderSize = 0;
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnZaposlenici.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnZaposlenici, "zaposlenik");
            this.helpProvider1.SetHelpNavigator(this.btnZaposlenici, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnZaposlenici.Location = new System.Drawing.Point(12, 394);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.helpProvider1.SetShowHelp(this.btnZaposlenici, true);
            this.btnZaposlenici.Size = new System.Drawing.Size(163, 75);
            this.btnZaposlenici.TabIndex = 3;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.FlatAppearance.BorderSize = 0;
            this.btnVozila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVozila.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnVozila.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnVozila, "vozilo");
            this.helpProvider1.SetHelpNavigator(this.btnVozila, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnVozila.Location = new System.Drawing.Point(12, 475);
            this.btnVozila.Name = "btnVozila";
            this.helpProvider1.SetShowHelp(this.btnVozila, true);
            this.btnVozila.Size = new System.Drawing.Size(163, 75);
            this.btnVozila.TabIndex = 2;
            this.btnVozila.Text = "Vozila";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnRute
            // 
            this.btnRute.FlatAppearance.BorderSize = 0;
            this.btnRute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRute.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnRute.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnRute, "ruta");
            this.helpProvider1.SetHelpNavigator(this.btnRute, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider1.SetHelpString(this.btnRute, "");
            this.btnRute.Location = new System.Drawing.Point(12, 162);
            this.btnRute.Name = "btnRute";
            this.helpProvider1.SetShowHelp(this.btnRute, true);
            this.btnRute.Size = new System.Drawing.Size(163, 75);
            this.btnRute.TabIndex = 1;
            this.btnRute.Text = "Rute";
            this.btnRute.UseVisualStyleBackColor = true;
            this.btnRute.Click += new System.EventHandler(this.btnRute_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnStatistika.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnStatistika, "statistika");
            this.helpProvider1.SetHelpNavigator(this.btnStatistika, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnStatistika.Location = new System.Drawing.Point(12, 313);
            this.btnStatistika.Name = "btnStatistika";
            this.helpProvider1.SetShowHelp(this.btnStatistika, true);
            this.btnStatistika.Size = new System.Drawing.Size(163, 75);
            this.btnStatistika.TabIndex = 6;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpKeyword(this.btnEmail, "email");
            this.helpProvider1.SetHelpNavigator(this.btnEmail, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnEmail.Location = new System.Drawing.Point(12, 556);
            this.btnEmail.Name = "btnEmail";
            this.helpProvider1.SetShowHelp(this.btnEmail, true);
            this.btnEmail.Size = new System.Drawing.Size(163, 75);
            this.btnEmail.TabIndex = 8;
            this.btnEmail.Text = "Email servis";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // panelSadrzaj
            // 
            this.panelSadrzaj.Controls.Add(this.ispisTvrtkiUC1);
            this.panelSadrzaj.Controls.Add(this.profilUC2);
            this.panelSadrzaj.Controls.Add(this.ispisZapisnikaUC2);
            this.panelSadrzaj.Controls.Add(this.ispisRutaUC2);
            this.panelSadrzaj.Controls.Add(this.profilUC1);
            this.panelSadrzaj.Controls.Add(this.ispisZaposlenikaUC1);
            this.panelSadrzaj.Controls.Add(this.emailUC1);
            this.panelSadrzaj.Controls.Add(this.ispisVozilaUC1);
            this.panelSadrzaj.Controls.Add(this.statistikaUC2);
            this.panelSadrzaj.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSadrzaj.Location = new System.Drawing.Point(172, 0);
            this.panelSadrzaj.Name = "panelSadrzaj";
            this.panelSadrzaj.Size = new System.Drawing.Size(1277, 810);
            this.panelSadrzaj.TabIndex = 1;
            // 
            // ispisTvrtkiUC1
            // 
            this.ispisTvrtkiUC1.Location = new System.Drawing.Point(0, 0);
            this.ispisTvrtkiUC1.Name = "ispisTvrtkiUC1";
            this.ispisTvrtkiUC1.Size = new System.Drawing.Size(1277, 810);
            this.ispisTvrtkiUC1.TabIndex = 10;
            // 
            // profilUC2
            // 
            this.profilUC2.BackColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpKeyword(this.profilUC2, "profil");
            this.helpProvider1.SetHelpNavigator(this.profilUC2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.profilUC2.Location = new System.Drawing.Point(0, 0);
            this.profilUC2.Name = "profilUC2";
            this.helpProvider1.SetShowHelp(this.profilUC2, true);
            this.profilUC2.Size = new System.Drawing.Size(1277, 810);
            this.profilUC2.TabIndex = 8;
            // 
            // ispisZapisnikaUC2
            // 
            this.helpProvider1.SetHelpKeyword(this.ispisZapisnikaUC2, "zapisnik");
            this.helpProvider1.SetHelpNavigator(this.ispisZapisnikaUC2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.ispisZapisnikaUC2.Location = new System.Drawing.Point(0, 0);
            this.ispisZapisnikaUC2.Name = "ispisZapisnikaUC2";
            this.helpProvider1.SetShowHelp(this.ispisZapisnikaUC2, true);
            this.ispisZapisnikaUC2.Size = new System.Drawing.Size(1277, 810);
            this.ispisZapisnikaUC2.TabIndex = 7;
            // 
            // ispisRutaUC2
            // 
            this.helpProvider1.SetHelpKeyword(this.ispisRutaUC2, "ruta");
            this.helpProvider1.SetHelpNavigator(this.ispisRutaUC2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.ispisRutaUC2.Location = new System.Drawing.Point(0, 0);
            this.ispisRutaUC2.Name = "ispisRutaUC2";
            this.helpProvider1.SetShowHelp(this.ispisRutaUC2, true);
            this.ispisRutaUC2.Size = new System.Drawing.Size(1277, 810);
            this.ispisRutaUC2.TabIndex = 6;
            // 
            // profilUC1
            // 
            this.profilUC1.BackColor = System.Drawing.SystemColors.Control;
            this.helpProvider1.SetHelpKeyword(this.profilUC1, "profil");
            this.helpProvider1.SetHelpNavigator(this.profilUC1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.profilUC1.Location = new System.Drawing.Point(0, 0);
            this.profilUC1.Name = "profilUC1";
            this.helpProvider1.SetShowHelp(this.profilUC1, true);
            this.profilUC1.Size = new System.Drawing.Size(1277, 810);
            this.profilUC1.TabIndex = 5;
            // 
            // ispisZaposlenikaUC1
            // 
            this.helpProvider1.SetHelpKeyword(this.ispisZaposlenikaUC1, "zaposlenik");
            this.helpProvider1.SetHelpNavigator(this.ispisZaposlenikaUC1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.ispisZaposlenikaUC1.Location = new System.Drawing.Point(0, 0);
            this.ispisZaposlenikaUC1.Name = "ispisZaposlenikaUC1";
            this.helpProvider1.SetShowHelp(this.ispisZaposlenikaUC1, true);
            this.ispisZaposlenikaUC1.Size = new System.Drawing.Size(1277, 810);
            this.ispisZaposlenikaUC1.TabIndex = 4;
            // 
            // emailUC1
            // 
            this.helpProvider1.SetHelpKeyword(this.emailUC1, "email");
            this.helpProvider1.SetHelpNavigator(this.emailUC1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.emailUC1.Location = new System.Drawing.Point(0, 0);
            this.emailUC1.Name = "emailUC1";
            this.helpProvider1.SetShowHelp(this.emailUC1, true);
            this.emailUC1.Size = new System.Drawing.Size(1277, 810);
            this.emailUC1.TabIndex = 3;
            // 
            // ispisVozilaUC1
            // 
            this.helpProvider1.SetHelpKeyword(this.ispisVozilaUC1, "vozilo");
            this.helpProvider1.SetHelpNavigator(this.ispisVozilaUC1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.ispisVozilaUC1.Location = new System.Drawing.Point(0, 0);
            this.ispisVozilaUC1.Name = "ispisVozilaUC1";
            this.helpProvider1.SetShowHelp(this.ispisVozilaUC1, true);
            this.ispisVozilaUC1.Size = new System.Drawing.Size(1277, 810);
            this.ispisVozilaUC1.TabIndex = 1;
            // 
            // statistikaUC2
            // 
            this.helpProvider1.SetHelpKeyword(this.statistikaUC2, "statistika");
            this.helpProvider1.SetHelpNavigator(this.statistikaUC2, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.statistikaUC2.Location = new System.Drawing.Point(0, 0);
            this.statistikaUC2.Name = "statistikaUC2";
            this.helpProvider1.SetShowHelp(this.statistikaUC2, true);
            this.statistikaUC2.Size = new System.Drawing.Size(1277, 810);
            this.statistikaUC2.TabIndex = 9;
            // 
            // lblTvrka
            // 
            this.lblTvrka.AutoSize = true;
            this.lblTvrka.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTvrka.ForeColor = System.Drawing.Color.White;
            this.lblTvrka.Location = new System.Drawing.Point(37, 736);
            this.lblTvrka.Name = "lblTvrka";
            this.lblTvrka.Size = new System.Drawing.Size(62, 21);
            this.lblTvrka.TabIndex = 10;
            this.lblTvrka.Text = "Tvrtka";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 810);
            this.Controls.Add(this.panelSadrzaj);
            this.Controls.Add(this.panelMeni);
            this.helpProvider1.SetHelpKeyword(this, "glavnaforma");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForma";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaForma_FormClosed);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.panelMeni.ResumeLayout(false);
            this.panelMeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxProfil)).EndInit();
            this.panelSadrzaj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Button btnRute;
        private System.Windows.Forms.PictureBox pctBoxProfil;
        private System.Windows.Forms.Button btnZapisnici;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Panel panelMeniPozicija;
        private System.Windows.Forms.Panel panelSadrzaj;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private IspisRutaUC ispisRutaUC1;
        private IspisVozilaUC ispisVozilaUC1;
        private IspisZapisnikaUC ispisZapisnikaUC1;
        private StatistikaUC statistikaUC1;
        private System.Windows.Forms.Button btnEmail;
        private EmailUC emailUC1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogOut;
        private IspisZaposlenikaUC ispisZaposlenikaUC1;
        private ProfilUC profilUC1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private IspisZapisnikaUC ispisZapisnikaUC2;
        private IspisRutaUC ispisRutaUC2;
        private ProfilUC profilUC2;
        private StatistikaUC statistikaUC2;
        private Sloj_prezentacije.IspisTvrtkiUC ispisTvrtkiUC1;
        private System.Windows.Forms.Label lblTvrka;
    }
}