namespace TransportApp
{
    partial class EmailUC
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
            this.panelEmailMeni = new System.Windows.Forms.Panel();
            this.btnZaustaviServis = new System.Windows.Forms.Button();
            this.btnPokreniServis = new System.Windows.Forms.Button();
            this.lblStanje = new System.Windows.Forms.Label();
            this.panelEmailMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmailMeni
            // 
            this.panelEmailMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelEmailMeni.Controls.Add(this.btnZaustaviServis);
            this.panelEmailMeni.Controls.Add(this.btnPokreniServis);
            this.panelEmailMeni.Location = new System.Drawing.Point(0, 724);
            this.panelEmailMeni.Name = "panelEmailMeni";
            this.panelEmailMeni.Size = new System.Drawing.Size(1277, 86);
            this.panelEmailMeni.TabIndex = 7;
            // 
            // btnZaustaviServis
            // 
            this.btnZaustaviServis.FlatAppearance.BorderSize = 0;
            this.btnZaustaviServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaustaviServis.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnZaustaviServis.ForeColor = System.Drawing.Color.White;
            this.btnZaustaviServis.Location = new System.Drawing.Point(661, 8);
            this.btnZaustaviServis.Name = "btnZaustaviServis";
            this.btnZaustaviServis.Size = new System.Drawing.Size(209, 75);
            this.btnZaustaviServis.TabIndex = 6;
            this.btnZaustaviServis.Text = "Zaustavi servis";
            this.btnZaustaviServis.UseVisualStyleBackColor = true;
            this.btnZaustaviServis.Click += new System.EventHandler(this.btnZaustaviServis_Click);
            // 
            // btnPokreniServis
            // 
            this.btnPokreniServis.FlatAppearance.BorderSize = 0;
            this.btnPokreniServis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokreniServis.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnPokreniServis.ForeColor = System.Drawing.Color.White;
            this.btnPokreniServis.Location = new System.Drawing.Point(446, 8);
            this.btnPokreniServis.Name = "btnPokreniServis";
            this.btnPokreniServis.Size = new System.Drawing.Size(209, 75);
            this.btnPokreniServis.TabIndex = 5;
            this.btnPokreniServis.Text = "Pokreni servis";
            this.btnPokreniServis.UseVisualStyleBackColor = true;
            this.btnPokreniServis.Click += new System.EventHandler(this.btnPokreniServis_Click);
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStanje.Location = new System.Drawing.Point(212, 67);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(69, 30);
            this.lblStanje.TabIndex = 9;
            this.lblStanje.Text = "........";
            // 
            // EmailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.panelEmailMeni);
            this.Name = "EmailUC";
            this.Size = new System.Drawing.Size(1277, 810);
            this.panelEmailMeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmailMeni;
        private System.Windows.Forms.Button btnZaustaviServis;
        private System.Windows.Forms.Button btnPokreniServis;
        private System.Windows.Forms.Label lblStanje;
    }
}
