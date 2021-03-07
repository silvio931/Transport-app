namespace TransportApp
{
    partial class Izvještaj
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GreskaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VoziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZapisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GreskaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoziloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZapisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetGreska";
            reportDataSource1.Value = this.GreskaBindingSource;
            reportDataSource2.Name = "DataSetVozilo";
            reportDataSource2.Value = this.VoziloBindingSource;
            reportDataSource3.Name = "DataSetZaposlenik";
            reportDataSource3.Value = this.ZaposlenikBindingSource;
            reportDataSource4.Name = "DataSetZapisnik";
            reportDataSource4.Value = this.ZapisnikBindingSource;
            reportDataSource5.Name = "DataSetListaGreski";
            reportDataSource5.Value = this.ZapisnikBindingSource;
            reportDataSource6.Name = "DataSetRuta";
            reportDataSource6.Value = this.RutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TransportApp.AdminReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1381, 790);
            this.reportViewer1.TabIndex = 0;
            // 
            // GreskaBindingSource
            // 
            this.GreskaBindingSource.DataSource = typeof(TransportApp.Greska);
            // 
            // VoziloBindingSource
            // 
            this.VoziloBindingSource.DataSource = typeof(TransportApp.Vozilo);
            // 
            // ZaposlenikBindingSource
            // 
            this.ZaposlenikBindingSource.DataSource = typeof(TransportApp.Zaposlenik);
            // 
            // ZapisnikBindingSource
            // 
            this.ZapisnikBindingSource.DataSource = typeof(TransportApp.Zapisnik);
            // 
            // RutaBindingSource
            // 
            this.RutaBindingSource.DataSource = typeof(TransportApp.Ruta);
            // 
            // Izvještaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Izvještaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj";
            this.Load += new System.EventHandler(this.Izvještaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GreskaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoziloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZapisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RutaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GreskaBindingSource;
        private System.Windows.Forms.BindingSource VoziloBindingSource;
        private System.Windows.Forms.BindingSource ZaposlenikBindingSource;
        private System.Windows.Forms.BindingSource ZapisnikBindingSource;
        private System.Windows.Forms.BindingSource RutaBindingSource;
    }
}