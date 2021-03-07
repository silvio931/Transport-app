namespace TransportApp
{
    partial class PromjenaKorisnickogImenaForma
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNovoKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblNovoKorisnickoIme = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(238, 218);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 42);
            this.btnOdustani.TabIndex = 60;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(58, 218);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(120, 42);
            this.btnSpremi.TabIndex = 61;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(46, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 1);
            this.panel3.TabIndex = 55;
            // 
            // txtNovoKorisnickoIme
            // 
            this.txtNovoKorisnickoIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtNovoKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovoKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNovoKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.txtNovoKorisnickoIme.Location = new System.Drawing.Point(46, 72);
            this.txtNovoKorisnickoIme.Name = "txtNovoKorisnickoIme";
            this.txtNovoKorisnickoIme.Size = new System.Drawing.Size(321, 25);
            this.txtNovoKorisnickoIme.TabIndex = 59;
            // 
            // lblNovoKorisnickoIme
            // 
            this.lblNovoKorisnickoIme.AutoSize = true;
            this.lblNovoKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNovoKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.lblNovoKorisnickoIme.Location = new System.Drawing.Point(41, 48);
            this.lblNovoKorisnickoIme.Name = "lblNovoKorisnickoIme";
            this.lblNovoKorisnickoIme.Size = new System.Drawing.Size(174, 21);
            this.lblNovoKorisnickoIme.TabIndex = 57;
            this.lblNovoKorisnickoIme.Text = "Novo korisničko ime";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 184);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 62;
            // 
            // PromjenaKorisnickogImenaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(422, 308);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNovoKorisnickoIme);
            this.Controls.Add(this.lblNovoKorisnickoIme);
            this.Name = "PromjenaKorisnickogImenaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena korisničkog imena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNovoKorisnickoIme;
        private System.Windows.Forms.Label lblNovoKorisnickoIme;
        private System.Windows.Forms.Label lblError;
    }
}