using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Statistika;

namespace TransportApp
{
    public partial class StatistikaUC : UserControl
    {
        GenerirajStatistiku generirajStatistiku = new GenerirajStatistiku();
        //konstruktor
        public StatistikaUC()
        {
            InitializeComponent();
            if (PrijavaForma.uloga == 3)
            {
                lblGrafRute.Text = "Usporedba odvoženih ruta s prosjekom tvrtke";
            }
            if (PrijavaForma.uloga == 1 || PrijavaForma.uloga==2)
            {
                lblGrafRute.Text = "Usporedba kreiranih ruta s prosjekom tvrtke";
            }
        }

        public void Učitaj()
        {

            lblOdvoženeVrijednost.Text = generirajStatistiku.DohvatiBrojOdvoženihRuta(PrijavaForma.uloga, PrijavaForma.oib, PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id).ToString();
            lblNeodvoženeVrijednost.Text = generirajStatistiku.DohvatiBrojNeodvoženihRuta(PrijavaForma.uloga, PrijavaForma.oib, PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id).ToString();
            lblOdvoženiUkupnoVrijednost.Text = generirajStatistiku.DOhvatiUkupnoVrijeme(PrijavaForma.uloga, PrijavaForma.oib, PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id).ToString();
            chartRute.Series[0].Points[0].YValues[0] = generirajStatistiku.DOhvatiProsjekRuta(PrijavaForma.uloga, PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id);
            if (PrijavaForma.uloga == 1)
            {
                chartRute.Series[0].Points[1].YValues[0] = generirajStatistiku.DohvatiAdminRute(PrijavaForma.oib);
            }
            else
            {
                chartRute.Series[0].Points[1].YValues[0] = generirajStatistiku.DohvatiBrojOdvoženihRuta(PrijavaForma.uloga, PrijavaForma.oib, PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id);
            }
            chartStaž.Series[0].Points[0].YValues[0] = generirajStatistiku.DohvatiProsjekStaž(PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id);
            chartStaž.Series[0].Points[1].YValues[0] = generirajStatistiku.DohvatiStaž(PrijavaForma.oib);
            chartStaž.Refresh();
            chartRute.Refresh();
        }

        //Metoda koja generira izvještaj
        private void btnKreirajIzvještaj_Click(object sender, EventArgs e)
        {
            Izvještaj izvještaj = new Izvještaj();
            izvještaj.Show();
        }

        //Metoda koja ispisuje dobivenu statistiku u pdf dokument
        private void btnIspisPisač_Click(object sender, EventArgs e)
        {

        }

        //Metoda koja ispisuje dobivenu statistiku na pisač
        private void btnIspisPDF_Click(object sender, EventArgs e)
        {
            Izvještaj izvještaj = new Izvještaj();
        }

        private void StatistikaUC_Load(object sender, EventArgs e)
        {
        }

        private void StatistikaUC_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void chartStatistika_Click(object sender, EventArgs e)
        {
        }

        private void btnUcitajStatistiku_Click(object sender, EventArgs e)
        {
            Učitaj();
        }
    }
}
