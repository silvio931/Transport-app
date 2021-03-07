namespace TransportApp
{
    partial class IspisZapisnikaUC
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
            this.pnlZapisniciMeni = new System.Windows.Forms.Panel();
            this.btnUcitajPodatke = new System.Windows.Forms.Button();
            this.btnObrađenNeobrađen = new System.Windows.Forms.Button();
            this.btnAžurirajZapisnik = new System.Windows.Forms.Button();
            this.btnIzbrišiZapisnik = new System.Windows.Forms.Button();
            this.btnDodajZapisnik = new System.Windows.Forms.Button();
            this.dgvZapisnici = new System.Windows.Forms.DataGridView();
            this.dgvGreske = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlZapisniciMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGreske)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlZapisniciMeni
            // 
            this.pnlZapisniciMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlZapisniciMeni.Controls.Add(this.btnUcitajPodatke);
            this.pnlZapisniciMeni.Controls.Add(this.btnObrađenNeobrađen);
            this.pnlZapisniciMeni.Controls.Add(this.btnAžurirajZapisnik);
            this.pnlZapisniciMeni.Controls.Add(this.btnIzbrišiZapisnik);
            this.pnlZapisniciMeni.Controls.Add(this.btnDodajZapisnik);
            this.pnlZapisniciMeni.Location = new System.Drawing.Point(0, 724);
            this.pnlZapisniciMeni.Name = "pnlZapisniciMeni";
            this.pnlZapisniciMeni.Size = new System.Drawing.Size(1277, 86);
            this.pnlZapisniciMeni.TabIndex = 5;
            // 
            // btnUcitajPodatke
            // 
            this.btnUcitajPodatke.FlatAppearance.BorderSize = 0;
            this.btnUcitajPodatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPodatke.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnUcitajPodatke.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPodatke.Location = new System.Drawing.Point(0, 3);
            this.btnUcitajPodatke.Name = "btnUcitajPodatke";
            this.btnUcitajPodatke.Size = new System.Drawing.Size(163, 75);
            this.btnUcitajPodatke.TabIndex = 9;
            this.btnUcitajPodatke.Text = "Učitaj podatke";
            this.btnUcitajPodatke.UseVisualStyleBackColor = true;
            this.btnUcitajPodatke.Click += new System.EventHandler(this.btnUcitajPodatke_Click);
            // 
            // btnObrađenNeobrađen
            // 
            this.btnObrađenNeobrađen.FlatAppearance.BorderSize = 0;
            this.btnObrađenNeobrađen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrađenNeobrađen.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnObrađenNeobrađen.ForeColor = System.Drawing.Color.White;
            this.btnObrađenNeobrađen.Location = new System.Drawing.Point(778, 8);
            this.btnObrađenNeobrađen.Name = "btnObrađenNeobrađen";
            this.btnObrađenNeobrađen.Size = new System.Drawing.Size(355, 75);
            this.btnObrađenNeobrađen.TabIndex = 8;
            this.btnObrađenNeobrađen.Text = "Obrađen/neobrađen";
            this.btnObrađenNeobrađen.UseVisualStyleBackColor = true;
            this.btnObrađenNeobrađen.Click += new System.EventHandler(this.btnObrađenNeobrađen_Click);
            // 
            // btnAžurirajZapisnik
            // 
            this.btnAžurirajZapisnik.FlatAppearance.BorderSize = 0;
            this.btnAžurirajZapisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAžurirajZapisnik.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAžurirajZapisnik.ForeColor = System.Drawing.Color.White;
            this.btnAžurirajZapisnik.Location = new System.Drawing.Point(564, 8);
            this.btnAžurirajZapisnik.Name = "btnAžurirajZapisnik";
            this.btnAžurirajZapisnik.Size = new System.Drawing.Size(255, 75);
            this.btnAžurirajZapisnik.TabIndex = 7;
            this.btnAžurirajZapisnik.Text = "Ažuriraj zapisnik";
            this.btnAžurirajZapisnik.UseVisualStyleBackColor = true;
            this.btnAžurirajZapisnik.Click += new System.EventHandler(this.btnAžurirajZapisnik_Click);
            // 
            // btnIzbrišiZapisnik
            // 
            this.btnIzbrišiZapisnik.FlatAppearance.BorderSize = 0;
            this.btnIzbrišiZapisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrišiZapisnik.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnIzbrišiZapisnik.ForeColor = System.Drawing.Color.White;
            this.btnIzbrišiZapisnik.Location = new System.Drawing.Point(367, 8);
            this.btnIzbrišiZapisnik.Name = "btnIzbrišiZapisnik";
            this.btnIzbrišiZapisnik.Size = new System.Drawing.Size(209, 75);
            this.btnIzbrišiZapisnik.TabIndex = 6;
            this.btnIzbrišiZapisnik.Text = "Izbriši zapisnik";
            this.btnIzbrišiZapisnik.UseVisualStyleBackColor = true;
            this.btnIzbrišiZapisnik.Click += new System.EventHandler(this.btnIzbrišiZapisnik_Click);
            // 
            // btnDodajZapisnik
            // 
            this.btnDodajZapisnik.FlatAppearance.BorderSize = 0;
            this.btnDodajZapisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZapisnik.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnDodajZapisnik.ForeColor = System.Drawing.Color.White;
            this.btnDodajZapisnik.Location = new System.Drawing.Point(152, 8);
            this.btnDodajZapisnik.Name = "btnDodajZapisnik";
            this.btnDodajZapisnik.Size = new System.Drawing.Size(209, 75);
            this.btnDodajZapisnik.TabIndex = 5;
            this.btnDodajZapisnik.Text = "Kreiraj zapisnik";
            this.btnDodajZapisnik.UseVisualStyleBackColor = true;
            this.btnDodajZapisnik.Click += new System.EventHandler(this.btnDodajZapisnik_Click);
            // 
            // dgvZapisnici
            // 
            this.dgvZapisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvZapisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZapisnici.Location = new System.Drawing.Point(26, 22);
            this.dgvZapisnici.Name = "dgvZapisnici";
            this.dgvZapisnici.RowHeadersWidth = 51;
            this.dgvZapisnici.RowTemplate.Height = 24;
            this.dgvZapisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZapisnici.Size = new System.Drawing.Size(699, 656);
            this.dgvZapisnici.TabIndex = 4;
            this.dgvZapisnici.SelectionChanged += new System.EventHandler(this.dgvZapisnici_SelectionChanged);
            // 
            // dgvGreske
            // 
            this.dgvGreske.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGreske.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGreske.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGreske.Location = new System.Drawing.Point(731, 22);
            this.dgvGreske.Name = "dgvGreske";
            this.dgvGreske.RowHeadersWidth = 51;
            this.dgvGreske.RowTemplate.Height = 24;
            this.dgvGreske.Size = new System.Drawing.Size(543, 656);
            this.dgvGreske.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(533, 692);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 12;
            // 
            // IspisZapisnikaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgvGreske);
            this.Controls.Add(this.pnlZapisniciMeni);
            this.Controls.Add(this.dgvZapisnici);
            this.Name = "IspisZapisnikaUC";
            this.Size = new System.Drawing.Size(1277, 810);
            this.pnlZapisniciMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGreske)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlZapisniciMeni;
        private System.Windows.Forms.Button btnAžurirajZapisnik;
        private System.Windows.Forms.Button btnIzbrišiZapisnik;
        private System.Windows.Forms.Button btnDodajZapisnik;
        private System.Windows.Forms.DataGridView dgvZapisnici;
        private System.Windows.Forms.Button btnObrađenNeobrađen;
        private System.Windows.Forms.DataGridView dgvGreske;
        private System.Windows.Forms.Button btnUcitajPodatke;
        private System.Windows.Forms.Label lblError;
    }
}
