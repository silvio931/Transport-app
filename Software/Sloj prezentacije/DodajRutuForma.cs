using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class DodajRutuForma : Form
    {
        Ruta staraRuta;
        VoziloRepozitorij voziloRepozitorij = new VoziloRepozitorij();
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        RutaRepozitorij rutaRepozitorij = new RutaRepozitorij();


        public static DateTime vrijemePolaska;
        public static DateTime vrijemeDolaska;


        //Konstruktor
        public DodajRutuForma()
        {
            InitializeComponent();
       
        }

        //Konstruktor koji se poziva kod ažuriranja, prima parametar ruta koje se dohvaća iz kontrole IspisRutaUC pomoću metode 
        //DohvatiSelektiranuRutu, i zatim podatke o toj ruti stavlja unutar textboxeva itd. u formi koji se mogu mijenjati
        public DodajRutuForma(Ruta ruta)
        {
            InitializeComponent();
            cmbBoxVozilo.DataSource = voziloRepozitorij.DohvatiVozila();
            cmbBoxZaposlenik.DataSource = zaposlenikRepozitorij.DohvatiZaposlenike();
            staraRuta = ruta;

            txtBoxPolazište.Text = staraRuta.Polazište;
            txtBoxOdredište.Text = staraRuta.Odredište;
            txtBoxBrojOtpremnice.Text = staraRuta.Broj_otpremnice;

            dtpPolazakDatum.Value = DateTime.Parse(staraRuta.Datum_i_vrijeme_polaska);
            dtpPolazakSat.Value = DateTime.Parse(staraRuta.Datum_i_vrijeme_polaska);
            dtpdolazakDatum.Value = DateTime.Parse(staraRuta.Očekivano_vrijeme_dolaska);
            dtpDolazakSat.Value = DateTime.Parse(staraRuta.Očekivano_vrijeme_dolaska);

        }

        //Metoda koja vraća rutu u koju su pohranjeni svi podaci u kontroli IspisRutaUC na pritisak tipke Dodaj nakon zatvaranja
        //DodajRutuForma i zatim se pomoću klase RutaRepozotorij upisuje nova ruta u bazu
        public Ruta VratiRutu()
        {
            Zaposlenik selektiran = cmbBoxZaposlenik.SelectedItem as Zaposlenik;
            Vozilo selektirano = cmbBoxVozilo.SelectedItem as Vozilo;
            Ruta ruta = new Ruta();
            if (staraRuta != null)
            {
                ruta.Ruta_id = staraRuta.Ruta_id;
            }
            if (selektiran != null && selektirano != null && txtBoxPolazište.Text != "" && txtBoxOdredište.Text != "" && txtBoxBrojOtpremnice.Text != "")
            {
                ruta.Zaposlenik_id = selektiran.OIB;
                ruta.Kreirao = PrijavaForma.oib;
                ruta.Vozilo_registracija = selektirano.Registracija;
                ruta.Polazište = txtBoxPolazište.Text;
                ruta.Odredište = txtBoxOdredište.Text;
                ruta.Broj_otpremnice = txtBoxBrojOtpremnice.Text;
                DateTime polazak = dtpPolazakDatum.Value.Date + dtpPolazakSat.Value.TimeOfDay;
                DateTime dolazak = dtpdolazakDatum.Value.Date + dtpDolazakSat.Value.TimeOfDay;
                ruta.Datum_i_vrijeme_polaska = polazak.ToString();
                ruta.Očekivano_vrijeme_dolaska = dolazak.ToString();
                return ruta;
            }
            else
            {
                return null;
            }
        }

        //Tipka za odustajanje od kreiranja nove rute
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pritisak na ovu tipku će u novo kreiranu rutu upisivati podatke, te će ispisRutaUC te podatke dohvaćati
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (staraRuta == null)
            {
                try
                {
                    if (rutaRepozitorij.DodajRutu(VratiRutu()) == 0)
                    {
                        lblError.Text="Neispravni podaci!";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                 catch(System.Data.SqlClient.SqlException)
                {
                    lblError.Text ="Postoji ruta s istom otpremnicom!";
                }
            }
            else
            {
                try
                {
                    if (rutaRepozitorij.AžurirajRutu(VratiRutu()) == 0)
                    {
                        lblError.Text = "Neispravni podaci!";
                    }
                    else
                    {
                        this.Close();
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lblError.Text = "Postoji ruta s istom otpremnicom!";
                }
            }
        }

        public void dtpPolazakDatum_ValueChanged(object sender, EventArgs e)
        {
             vrijemePolaska= dtpPolazakDatum.Value.Date + dtpPolazakSat.Value.TimeOfDay;
            cmbBoxZaposlenik.DataSource = zaposlenikRepozitorij.DohvatiVozačeRuta();
            cmbBoxVozilo.DataSource = voziloRepozitorij.DohvatiVoziloRuta();
        }

        private void dtpPolazakSat_ValueChanged(object sender, EventArgs e)
        {
            DodajRutuForma.vrijemePolaska = dtpPolazakDatum.Value.Date + dtpPolazakSat.Value.TimeOfDay;
            cmbBoxZaposlenik.DataSource = zaposlenikRepozitorij.DohvatiVozačeRuta();
            cmbBoxVozilo.DataSource = voziloRepozitorij.DohvatiVoziloRuta();
        }

        private void dtpdolazakDatum_ValueChanged(object sender, EventArgs e)
        {
            vrijemeDolaska = dtpdolazakDatum.Value.Date + dtpDolazakSat.Value.TimeOfDay;
            cmbBoxZaposlenik.DataSource = zaposlenikRepozitorij.DohvatiVozačeRuta();
            cmbBoxVozilo.DataSource = voziloRepozitorij.DohvatiVoziloRuta();
        }

        private void dtpDolazakSat_ValueChanged(object sender, EventArgs e)
        {
            vrijemeDolaska = dtpDolazakSat.Value.Date + dtpDolazakSat.Value.TimeOfDay;
            cmbBoxZaposlenik.DataSource = zaposlenikRepozitorij.DohvatiVozačeRuta();
            cmbBoxVozilo.DataSource = voziloRepozitorij.DohvatiVoziloRuta();
        }
    }
}
