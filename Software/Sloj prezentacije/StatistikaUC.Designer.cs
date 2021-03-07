namespace TransportApp
{
    partial class StatistikaUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn3 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn4 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            this.panelRutaMeni = new System.Windows.Forms.Panel();
            this.btnUcitajStatistiku = new System.Windows.Forms.Button();
            this.btnKreirajIzvještaj = new System.Windows.Forms.Button();
            this.chartRute = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblOdvoženeVrijednost = new System.Windows.Forms.Label();
            this.lblOdvoženeRute = new System.Windows.Forms.Label();
            this.lblNeodvoženeRute = new System.Windows.Forms.Label();
            this.lblNeodvoženeVrijednost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOdvoženiUkupno = new System.Windows.Forms.Label();
            this.lblOdvoženiUkupnoVrijednost = new System.Windows.Forms.Label();
            this.chartStaž = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGrafStaž = new System.Windows.Forms.Label();
            this.lblGrafRute = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.panelRutaMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaž)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRutaMeni
            // 
            this.panelRutaMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelRutaMeni.Controls.Add(this.btnUcitajStatistiku);
            this.panelRutaMeni.Controls.Add(this.btnKreirajIzvještaj);
            this.panelRutaMeni.Location = new System.Drawing.Point(0, 724);
            this.panelRutaMeni.Name = "panelRutaMeni";
            this.panelRutaMeni.Size = new System.Drawing.Size(1277, 86);
            this.panelRutaMeni.TabIndex = 6;
            // 
            // btnUcitajStatistiku
            // 
            this.btnUcitajStatistiku.FlatAppearance.BorderSize = 0;
            this.btnUcitajStatistiku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajStatistiku.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnUcitajStatistiku.ForeColor = System.Drawing.Color.White;
            this.btnUcitajStatistiku.Location = new System.Drawing.Point(352, 8);
            this.btnUcitajStatistiku.Name = "btnUcitajStatistiku";
            this.btnUcitajStatistiku.Size = new System.Drawing.Size(209, 75);
            this.btnUcitajStatistiku.TabIndex = 6;
            this.btnUcitajStatistiku.Text = "Učitaj statistiku";
            this.btnUcitajStatistiku.UseVisualStyleBackColor = true;
            this.btnUcitajStatistiku.Click += new System.EventHandler(this.btnUcitajStatistiku_Click);
            // 
            // btnKreirajIzvještaj
            // 
            this.btnKreirajIzvještaj.FlatAppearance.BorderSize = 0;
            this.btnKreirajIzvještaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajIzvještaj.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnKreirajIzvještaj.ForeColor = System.Drawing.Color.White;
            this.btnKreirajIzvještaj.Location = new System.Drawing.Point(713, 8);
            this.btnKreirajIzvještaj.Name = "btnKreirajIzvještaj";
            this.btnKreirajIzvještaj.Size = new System.Drawing.Size(209, 75);
            this.btnKreirajIzvještaj.TabIndex = 5;
            this.btnKreirajIzvještaj.Text = "Kreiraj izvještaj";
            this.btnKreirajIzvještaj.UseVisualStyleBackColor = true;
            this.btnKreirajIzvještaj.Click += new System.EventHandler(this.btnKreirajIzvještaj_Click);
            // 
            // chartRute
            // 
            this.chartRute.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartRute.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legendCellColumn1.Name = "Column1";
            legendCellColumn2.Name = "Column2";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.CellColumns.Add(legendCellColumn2);
            legend1.Enabled = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chartRute.Legends.Add(legend1);
            this.chartRute.Location = new System.Drawing.Point(3, 250);
            this.chartRute.Name = "chartRute";
            this.chartRute.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint2.Color = System.Drawing.Color.Red;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chartRute.Series.Add(series1);
            this.chartRute.Size = new System.Drawing.Size(588, 443);
            this.chartRute.TabIndex = 13;
            this.chartRute.Click += new System.EventHandler(this.chartStatistika_Click);
            // 
            // lblOdvoženeVrijednost
            // 
            this.lblOdvoženeVrijednost.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdvoženeVrijednost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblOdvoženeVrijednost.Location = new System.Drawing.Point(195, 135);
            this.lblOdvoženeVrijednost.Name = "lblOdvoženeVrijednost";
            this.lblOdvoženeVrijednost.Size = new System.Drawing.Size(256, 82);
            this.lblOdvoženeVrijednost.TabIndex = 14;
            this.lblOdvoženeVrijednost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdvoženeRute
            // 
            this.lblOdvoženeRute.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblOdvoženeRute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblOdvoženeRute.Location = new System.Drawing.Point(208, 53);
            this.lblOdvoženeRute.Name = "lblOdvoženeRute";
            this.lblOdvoženeRute.Size = new System.Drawing.Size(235, 94);
            this.lblOdvoženeRute.TabIndex = 16;
            this.lblOdvoženeRute.Text = "Odvožene\r\nrute\r\n";
            this.lblOdvoženeRute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeodvoženeRute
            // 
            this.lblNeodvoženeRute.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblNeodvoženeRute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblNeodvoženeRute.Location = new System.Drawing.Point(550, 55);
            this.lblNeodvoženeRute.Name = "lblNeodvoženeRute";
            this.lblNeodvoženeRute.Size = new System.Drawing.Size(227, 94);
            this.lblNeodvoženeRute.TabIndex = 22;
            this.lblNeodvoženeRute.Text = "Neodvožene\r\nrute\r\n";
            this.lblNeodvoženeRute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNeodvoženeVrijednost
            // 
            this.lblNeodvoženeVrijednost.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeodvoženeVrijednost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblNeodvoženeVrijednost.Location = new System.Drawing.Point(521, 135);
            this.lblNeodvoženeVrijednost.Name = "lblNeodvoženeVrijednost";
            this.lblNeodvoženeVrijednost.Size = new System.Drawing.Size(256, 82);
            this.lblNeodvoženeVrijednost.TabIndex = 21;
            this.lblNeodvoženeVrijednost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Location = new System.Drawing.Point(231, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 3);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Location = new System.Drawing.Point(566, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 3);
            this.panel2.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(925, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 3);
            this.panel5.TabIndex = 32;
            // 
            // lblOdvoženiUkupno
            // 
            this.lblOdvoženiUkupno.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblOdvoženiUkupno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblOdvoženiUkupno.Location = new System.Drawing.Point(918, 50);
            this.lblOdvoženiUkupno.Name = "lblOdvoženiUkupno";
            this.lblOdvoženiUkupno.Size = new System.Drawing.Size(219, 88);
            this.lblOdvoženiUkupno.TabIndex = 31;
            this.lblOdvoženiUkupno.Text = "Odvoženi\r\ndani\r\n\r\n\r\n";
            this.lblOdvoženiUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdvoženiUkupnoVrijednost
            // 
            this.lblOdvoženiUkupnoVrijednost.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdvoženiUkupnoVrijednost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lblOdvoženiUkupnoVrijednost.Location = new System.Drawing.Point(887, 141);
            this.lblOdvoženiUkupnoVrijednost.Name = "lblOdvoženiUkupnoVrijednost";
            this.lblOdvoženiUkupnoVrijednost.Size = new System.Drawing.Size(262, 82);
            this.lblOdvoženiUkupnoVrijednost.TabIndex = 30;
            this.lblOdvoženiUkupnoVrijednost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStaž
            // 
            this.chartStaž.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartStaž.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legendCellColumn3.Name = "Column1";
            legendCellColumn4.Name = "Column2";
            legend2.CellColumns.Add(legendCellColumn3);
            legend2.CellColumns.Add(legendCellColumn4);
            legend2.Enabled = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chartStaž.Legends.Add(legend2);
            this.chartStaž.Location = new System.Drawing.Point(654, 250);
            this.chartStaž.Name = "chartStaž";
            this.chartStaž.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            dataPoint4.Color = System.Drawing.Color.Red;
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.chartStaž.Series.Add(series2);
            this.chartStaž.Size = new System.Drawing.Size(588, 443);
            this.chartStaž.TabIndex = 33;
            this.chartStaž.Text = "chart1";
            // 
            // lblGrafStaž
            // 
            this.lblGrafStaž.AutoSize = true;
            this.lblGrafStaž.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrafStaž.Location = new System.Drawing.Point(866, 676);
            this.lblGrafStaž.Name = "lblGrafStaž";
            this.lblGrafStaž.Size = new System.Drawing.Size(203, 21);
            this.lblGrafStaž.TabIndex = 34;
            this.lblGrafStaž.Text = "Radni staž u mjesecima";
            // 
            // lblGrafRute
            // 
            this.lblGrafRute.AutoSize = true;
            this.lblGrafRute.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrafRute.Location = new System.Drawing.Point(164, 672);
            this.lblGrafRute.Name = "lblGrafRute";
            this.lblGrafRute.Size = new System.Drawing.Size(60, 21);
            this.lblGrafRute.TabIndex = 35;
            this.lblGrafRute.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(597, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 16);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Location = new System.Drawing.Point(597, 295);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 16);
            this.panel4.TabIndex = 37;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(604, 314);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(54, 17);
            this.lblProsjek.TabIndex = 38;
            this.lblProsjek.Text = "prosjek";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(604, 369);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(56, 17);
            this.lblKorisnik.TabIndex = 39;
            this.lblKorisnik.Text = "korisnik";
            // 
            // StatistikaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblGrafRute);
            this.Controls.Add(this.lblGrafStaž);
            this.Controls.Add(this.chartStaž);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblOdvoženiUkupno);
            this.Controls.Add(this.lblOdvoženiUkupnoVrijednost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNeodvoženeRute);
            this.Controls.Add(this.lblNeodvoženeVrijednost);
            this.Controls.Add(this.lblOdvoženeRute);
            this.Controls.Add(this.chartRute);
            this.Controls.Add(this.panelRutaMeni);
            this.Controls.Add(this.lblOdvoženeVrijednost);
            this.Name = "StatistikaUC";
            this.Size = new System.Drawing.Size(1277, 810);
            this.Load += new System.EventHandler(this.StatistikaUC_Load);
            this.VisibleChanged += new System.EventHandler(this.StatistikaUC_VisibleChanged);
            this.panelRutaMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaž)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRutaMeni;
        private System.Windows.Forms.Button btnKreirajIzvještaj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRute;
        private System.Windows.Forms.Label lblOdvoženeVrijednost;
        private System.Windows.Forms.Label lblOdvoženeRute;
        private System.Windows.Forms.Label lblNeodvoženeRute;
        private System.Windows.Forms.Label lblNeodvoženeVrijednost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblOdvoženiUkupno;
        private System.Windows.Forms.Label lblOdvoženiUkupnoVrijednost;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaž;
        private System.Windows.Forms.Label lblGrafStaž;
        private System.Windows.Forms.Label lblGrafRute;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnUcitajStatistiku;
    }
}
