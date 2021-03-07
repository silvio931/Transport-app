using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using SqlServerTypes;

namespace TransportApp
{
    public partial class GlavnaForma : Form
    {
        public static Zaposlenik prijavljeniZaposlenik;
        static string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        string path2 = path + "\\Software\\Resources\\Korisnicka_dokumentacija.chm";

        public GlavnaForma(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            ispisRutaUC2.Hide();
            ispisVozilaUC1.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            emailUC1.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC1.Hide();
            profilUC2.Hide();
            ispisTvrtkiUC1.Hide();
            helpProvider1.HelpNamespace = path2;
            prijavljeniZaposlenik = zaposlenik;
            lblUsername.Text = zaposlenik.KorisnickoIme;
            if (zaposlenik.Tvrtka == null)
            {
                lblTvrka.Text = "";
            }
            else
            {
                lblTvrka.Text = zaposlenik.Tvrtka.Naziv;
            }
            

            if(prijavljeniZaposlenik.Uloga.Uloga_id == 2)
            {
                btnEmail.Hide();
            }

            if (prijavljeniZaposlenik.Uloga.Uloga_id == 3)
            {
                btnZaposlenici.Hide();
                btnEmail.Hide();
                btnVozila.Hide();
            }
            if (prijavljeniZaposlenik.Uloga.Uloga_id == 4)
            {
                btnZaposlenici.Hide();
                btnEmail.Hide();
                btnVozila.Hide();
                btnRute.Hide();
                btnZapisnici.Hide();
                btnStatistika.Hide();
                pctBoxProfil.Hide();
                ispisTvrtkiUC1.Show();
            }
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            panelMeniPozicija.Hide();
        }

        private void btnRute_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnRute.Height;
            panelMeniPozicija.Top = btnRute.Top;

            ispisVozilaUC1.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            emailUC1.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Hide();
            ispisRutaUC2.Show();

            
            

        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnVozila.Height;
            panelMeniPozicija.Top = btnVozila.Top;

            ispisRutaUC2.Hide();
            emailUC1.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Hide();
            ispisVozilaUC1.Show();
            
           
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnZaposlenici.Height;
            panelMeniPozicija.Top = btnZaposlenici.Top;

            ispisRutaUC2.Hide();
            ispisVozilaUC1.Hide();
            emailUC1.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            profilUC2.Hide();
            ispisZaposlenikaUC1.Show();
        }

        private void btnZapisnici_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnZapisnici.Height;
            panelMeniPozicija.Top = btnZapisnici.Top;

            ispisVozilaUC1.Hide();
            ispisRutaUC2.Hide();
            statistikaUC2.Hide();
            emailUC1.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Hide();
            ispisZapisnikaUC2.Show();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnStatistika.Height;
            panelMeniPozicija.Top = btnStatistika.Top;

            ispisVozilaUC1.Hide();
            ispisRutaUC2.Hide();
            emailUC1.Hide();
            ispisZapisnikaUC2.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Hide();
            statistikaUC2.Show();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Database.Instance.CloseConnection();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = btnEmail.Height;
            panelMeniPozicija.Top = btnEmail.Top;

            ispisVozilaUC1.Hide();
            ispisRutaUC2.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Hide();
            emailUC1.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            PrijavaForma prijavaforma = new PrijavaForma();
            this.Hide();
            prijavaforma.Show();
        }

        private void pctBoxProfil_Click(object sender, EventArgs e)
        {
            panelMeniPozicija.Show();
            panelMeniPozicija.Height = pctBoxProfil.Height;
            panelMeniPozicija.Top = pctBoxProfil.Top;

            ispisVozilaUC1.Hide();
            ispisRutaUC2.Hide();
            ispisZapisnikaUC2.Hide();
            statistikaUC2.Hide();
            ispisZaposlenikaUC1.Hide();
            profilUC2.Show();
            emailUC1.Hide();
        }

        //Zatvara konekciju s bazom
        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.Instance.CloseConnection();
        }
    }
}
