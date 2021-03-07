namespace TransportApp
{
    partial class IspisVozilaUC
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
            this.pnlVoziloMeni = new System.Windows.Forms.Panel();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnAžurirajVozilo = new System.Windows.Forms.Button();
            this.btnIzbrišiVozilo = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlVoziloMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVoziloMeni
            // 
            this.pnlVoziloMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlVoziloMeni.Controls.Add(this.btnUcitaj);
            this.pnlVoziloMeni.Controls.Add(this.btnAžurirajVozilo);
            this.pnlVoziloMeni.Controls.Add(this.btnIzbrišiVozilo);
            this.pnlVoziloMeni.Controls.Add(this.btnDodajVozilo);
            this.pnlVoziloMeni.Location = new System.Drawing.Point(0, 724);
            this.pnlVoziloMeni.Name = "pnlVoziloMeni";
            this.pnlVoziloMeni.Size = new System.Drawing.Size(1277, 86);
            this.pnlVoziloMeni.TabIndex = 3;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.FlatAppearance.BorderSize = 0;
            this.btnUcitaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitaj.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnUcitaj.ForeColor = System.Drawing.Color.White;
            this.btnUcitaj.Location = new System.Drawing.Point(87, 8);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(209, 75);
            this.btnUcitaj.TabIndex = 8;
            this.btnUcitaj.Text = "Učitaj podatke";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // btnAžurirajVozilo
            // 
            this.btnAžurirajVozilo.FlatAppearance.BorderSize = 0;
            this.btnAžurirajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAžurirajVozilo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAžurirajVozilo.ForeColor = System.Drawing.Color.White;
            this.btnAžurirajVozilo.Location = new System.Drawing.Point(749, 8);
            this.btnAžurirajVozilo.Name = "btnAžurirajVozilo";
            this.btnAžurirajVozilo.Size = new System.Drawing.Size(209, 75);
            this.btnAžurirajVozilo.TabIndex = 7;
            this.btnAžurirajVozilo.Text = "Ažuriraj vozilo";
            this.btnAžurirajVozilo.UseVisualStyleBackColor = true;
            this.btnAžurirajVozilo.Click += new System.EventHandler(this.btnAžurirajVozilo_Click);
            // 
            // btnIzbrišiVozilo
            // 
            this.btnIzbrišiVozilo.FlatAppearance.BorderSize = 0;
            this.btnIzbrišiVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrišiVozilo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnIzbrišiVozilo.ForeColor = System.Drawing.Color.White;
            this.btnIzbrišiVozilo.Location = new System.Drawing.Point(534, 8);
            this.btnIzbrišiVozilo.Name = "btnIzbrišiVozilo";
            this.btnIzbrišiVozilo.Size = new System.Drawing.Size(209, 75);
            this.btnIzbrišiVozilo.TabIndex = 6;
            this.btnIzbrišiVozilo.Text = "Izbriši vozilo";
            this.btnIzbrišiVozilo.UseVisualStyleBackColor = true;
            this.btnIzbrišiVozilo.Click += new System.EventHandler(this.btnIzbrišiVozilo_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.FlatAppearance.BorderSize = 0;
            this.btnDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.White;
            this.btnDodajVozilo.Location = new System.Drawing.Point(319, 8);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(209, 75);
            this.btnDodajVozilo.TabIndex = 5;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // dgvVozila
            // 
            this.dgvVozila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(26, 22);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersWidth = 51;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.Size = new System.Drawing.Size(1227, 656);
            this.dgvVozila.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(568, 691);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 11;
            // 
            // IspisVozilaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlVoziloMeni);
            this.Controls.Add(this.dgvVozila);
            this.Name = "IspisVozilaUC";
            this.Size = new System.Drawing.Size(1277, 810);
            this.pnlVoziloMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVoziloMeni;
        private System.Windows.Forms.Button btnAžurirajVozilo;
        private System.Windows.Forms.Button btnIzbrišiVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Label lblError;
    }
}
