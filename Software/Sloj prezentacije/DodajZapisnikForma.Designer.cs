namespace TransportApp
{
    partial class DodajZapisnikForma
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
            this.lblOpisGreške = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtOpisGreške = new System.Windows.Forms.TextBox();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.clbGreske = new System.Windows.Forms.CheckedListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpisGreške
            // 
            this.lblOpisGreške.AutoSize = true;
            this.lblOpisGreške.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblOpisGreške.ForeColor = System.Drawing.Color.White;
            this.lblOpisGreške.Location = new System.Drawing.Point(40, 233);
            this.lblOpisGreške.Name = "lblOpisGreške";
            this.lblOpisGreške.Size = new System.Drawing.Size(106, 21);
            this.lblOpisGreške.TabIndex = 55;
            this.lblOpisGreške.Text = "Opis greške";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(43, 161);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(49, 21);
            this.lblRuta.TabIndex = 54;
            this.lblRuta.Text = "Ruta";
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(245, 432);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 42);
            this.btnOdustani.TabIndex = 53;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(44, 432);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(120, 42);
            this.btnSpremi.TabIndex = 52;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtOpisGreške
            // 
            this.txtOpisGreške.BackColor = System.Drawing.Color.White;
            this.txtOpisGreške.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpisGreške.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtOpisGreške.ForeColor = System.Drawing.Color.Black;
            this.txtOpisGreške.Location = new System.Drawing.Point(44, 269);
            this.txtOpisGreške.Multiline = true;
            this.txtOpisGreške.Name = "txtOpisGreške";
            this.txtOpisGreške.Size = new System.Drawing.Size(321, 118);
            this.txtOpisGreške.TabIndex = 46;
            // 
            // cmbRuta
            // 
            this.cmbRuta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(47, 185);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(318, 29);
            this.cmbRuta.TabIndex = 62;
            // 
            // clbGreske
            // 
            this.clbGreske.FormattingEnabled = true;
            this.clbGreske.Location = new System.Drawing.Point(49, 12);
            this.clbGreske.Name = "clbGreske";
            this.clbGreske.Size = new System.Drawing.Size(316, 123);
            this.clbGreske.TabIndex = 76;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(44, 409);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 77;
            // 
            // DodajZapisnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(409, 514);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.clbGreske);
            this.Controls.Add(this.cmbRuta);
            this.Controls.Add(this.lblOpisGreške);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtOpisGreške);
            this.Name = "DodajZapisnikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiranje zapisnika";
            this.Load += new System.EventHandler(this.DodajZapisnikForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisGreške;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtOpisGreške;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.CheckedListBox clbGreske;
        private System.Windows.Forms.Label lblError;
    }
}