namespace TransportApp
{
    partial class IspisZaposlenikaUC
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.pnlVoziloMeni = new System.Windows.Forms.Panel();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnAžurirajZaposlenika = new System.Windows.Forms.Button();
            this.btnIzbrišiZaposlenika = new System.Windows.Forms.Button();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.pnlVoziloMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(26, 22);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.RowHeadersWidth = 51;
            this.dgvZaposlenici.RowTemplate.Height = 24;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(1227, 656);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // pnlVoziloMeni
            // 
            this.pnlVoziloMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlVoziloMeni.Controls.Add(this.btnUcitaj);
            this.pnlVoziloMeni.Controls.Add(this.btnAžurirajZaposlenika);
            this.pnlVoziloMeni.Controls.Add(this.btnIzbrišiZaposlenika);
            this.pnlVoziloMeni.Controls.Add(this.btnDodajZaposlenika);
            this.pnlVoziloMeni.Location = new System.Drawing.Point(0, 724);
            this.pnlVoziloMeni.Name = "pnlVoziloMeni";
            this.pnlVoziloMeni.Size = new System.Drawing.Size(1277, 86);
            this.pnlVoziloMeni.TabIndex = 4;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.FlatAppearance.BorderSize = 0;
            this.btnUcitaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitaj.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnUcitaj.ForeColor = System.Drawing.Color.White;
            this.btnUcitaj.Location = new System.Drawing.Point(80, 3);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(209, 75);
            this.btnUcitaj.TabIndex = 8;
            this.btnUcitaj.Text = "Učitaj podatke";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnAžurirajZaposlenika
            // 
            this.btnAžurirajZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnAžurirajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAžurirajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAžurirajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnAžurirajZaposlenika.Location = new System.Drawing.Point(749, 8);
            this.btnAžurirajZaposlenika.Name = "btnAžurirajZaposlenika";
            this.btnAžurirajZaposlenika.Size = new System.Drawing.Size(209, 75);
            this.btnAžurirajZaposlenika.TabIndex = 7;
            this.btnAžurirajZaposlenika.Text = "Ažuriraj zaposlenika";
            this.btnAžurirajZaposlenika.UseVisualStyleBackColor = true;
            this.btnAžurirajZaposlenika.Click += new System.EventHandler(this.btnAžurirajZaposlenika_Click);
            // 
            // btnIzbrišiZaposlenika
            // 
            this.btnIzbrišiZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnIzbrišiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrišiZaposlenika.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnIzbrišiZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnIzbrišiZaposlenika.Location = new System.Drawing.Point(534, 8);
            this.btnIzbrišiZaposlenika.Name = "btnIzbrišiZaposlenika";
            this.btnIzbrišiZaposlenika.Size = new System.Drawing.Size(209, 75);
            this.btnIzbrišiZaposlenika.TabIndex = 6;
            this.btnIzbrišiZaposlenika.Text = "Izbriši zaposlenika";
            this.btnIzbrišiZaposlenika.UseVisualStyleBackColor = true;
            this.btnIzbrišiZaposlenika.Click += new System.EventHandler(this.btnIzbrišiZaposlenika_Click);
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZaposlenika.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnDodajZaposlenika.ForeColor = System.Drawing.Color.White;
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(319, 8);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(209, 75);
            this.btnDodajZaposlenika.TabIndex = 5;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(530, 691);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 11;
            // 
            // IspisZaposlenikaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlVoziloMeni);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "IspisZaposlenikaUC";
            this.Size = new System.Drawing.Size(1277, 810);
            this.Load += new System.EventHandler(this.IspisZaposlenikaUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.pnlVoziloMeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Panel pnlVoziloMeni;
        private System.Windows.Forms.Button btnAžurirajZaposlenika;
        private System.Windows.Forms.Button btnIzbrišiZaposlenika;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Label lblError;
    }
}
