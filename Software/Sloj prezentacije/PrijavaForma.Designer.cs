namespace TransportApp
{
    partial class PrijavaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForma));
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBoxPassword = new System.Windows.Forms.CheckBox();
            this.pctBoxUsername = new System.Windows.Forms.PictureBox();
            this.pctBoxPassword = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxPassword.Location = new System.Drawing.Point(104, 193);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(223, 25);
            this.txtBoxPassword.TabIndex = 2;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.txtBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.White;
            this.txtBoxUsername.Location = new System.Drawing.Point(104, 111);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(223, 25);
            this.txtBoxUsername.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(84, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(256, 44);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "TransportApp";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(152, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(104, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(104, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1);
            this.panel1.TabIndex = 7;
            // 
            // chkBoxPassword
            // 
            this.chkBoxPassword.AutoSize = true;
            this.chkBoxPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chkBoxPassword.ForeColor = System.Drawing.Color.White;
            this.chkBoxPassword.Location = new System.Drawing.Point(104, 248);
            this.chkBoxPassword.Name = "chkBoxPassword";
            this.chkBoxPassword.Size = new System.Drawing.Size(152, 25);
            this.chkBoxPassword.TabIndex = 11;
            this.chkBoxPassword.Text = "Vidljiva lozinka";
            this.chkBoxPassword.UseVisualStyleBackColor = true;
            this.chkBoxPassword.CheckedChanged += new System.EventHandler(this.chkBoxPassword_CheckedChanged);
            // 
            // pctBoxUsername
            // 
            this.pctBoxUsername.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxUsername.Image")));
            this.pctBoxUsername.Location = new System.Drawing.Point(26, 87);
            this.pctBoxUsername.Name = "pctBoxUsername";
            this.pctBoxUsername.Size = new System.Drawing.Size(72, 54);
            this.pctBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxUsername.TabIndex = 12;
            this.pctBoxUsername.TabStop = false;
            // 
            // pctBoxPassword
            // 
            this.pctBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxPassword.Image")));
            this.pctBoxPassword.Location = new System.Drawing.Point(26, 171);
            this.pctBoxPassword.Name = "pctBoxPassword";
            this.pctBoxPassword.Size = new System.Drawing.Size(72, 52);
            this.pctBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxPassword.TabIndex = 13;
            this.pctBoxPassword.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(110, 276);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 14;
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(407, 358);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pctBoxPassword);
            this.Controls.Add(this.pctBoxUsername);
            this.Controls.Add(this.chkBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxPassword);
            this.helpProvider1.SetHelpKeyword(this, "prijava");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrijavaForma";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrijavaForma_FormClosing);
            this.Enter += new System.EventHandler(this.btnLogin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBoxPassword;
        private System.Windows.Forms.PictureBox pctBoxUsername;
        private System.Windows.Forms.PictureBox pctBoxPassword;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblError;
    }
}

