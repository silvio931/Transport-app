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
    public partial class DodajVoziloForma : Form
    {
        VoziloRepozitorij voziloRepozitorij = new VoziloRepozitorij();
        Vozilo staroVozilo;

        //Konstruktor koji se koristi kada se dodaje novo vozilo
        public DodajVoziloForma()
        {
            InitializeComponent();
        }

        private void DodajVoziloForma_Load(object sender, EventArgs e)
        {
            cmbVrstaVozila.DataSource = voziloRepozitorij.DohvatiVrsteVozila();
        }

        //Konstruktor koji se poziva kod ažuriranja, prima parametar trenutnoVozilo koje se dohvaća iz kontrole IspisVozilaUC pomoću metode 
        //DohvatiSelektiranoVozilo, i zatim podatke o tom vozilu stavlja unutar textboxeva itd. u formi koji se mogu mijenjati
        public DodajVoziloForma(Vozilo vozilo)
        {
            InitializeComponent();
            txtRegistacija.ReadOnly = true;
            staroVozilo = vozilo;
            txtRegistacija.Text = staroVozilo.Registracija;
            cmbVrstaVozila.DataSource = voziloRepozitorij.DohvatiVrsteVozila();
            cmbVrstaVozila.SelectedIndex = staroVozilo.Vrsta_vozila-1;
            txtMarkaVozila.Text = staroVozilo.Marka;
            txtGodinaProizvodnje.Text = (staroVozilo.Godina_proizvodnje).ToString();
            txtNosivost.Text = staroVozilo.Nosivost;
        }

        // metoda koja vraća zaposlenika u kojeg su pohranjeni svi podaci kontroli IspisVozilaUC koja na prisitak tipke Spremi zatvara formu
        // i pomoću klase ZaposlenikRepozitorij azurira zaposlenika u bazi
        public Vozilo VratiVozilo()
        {
            VrstaVozila vrstaVozila = cmbVrstaVozila.SelectedItem as VrstaVozila;
            Vozilo vozilo = new Vozilo();
            vozilo.Registracija = txtRegistacija.Text;
            vozilo.Vrsta_vozila = vrstaVozila.vrsta_id;
            vozilo.Godina_proizvodnje = int.Parse(txtGodinaProizvodnje.Text);
            vozilo.Marka = txtMarkaVozila.Text;
            vozilo.Nosivost = txtNosivost.Text;
            return vozilo;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pritisak na ovu tipku će u novo kreirano vozilo upisivati podatke, te će IspisVozilaUC te podatke dohvaćati
        private void btnSpremi_Click(object sender, EventArgs e)
        {

            if (staroVozilo == null)
            {
                try
                {
                    voziloRepozitorij.DodajVozilo(VratiVozilo());
                    this.Close();
                }
                catch (System.FormatException)
                {
                    lblError.Text="Nisu ispravno unseni podaci!";
                }
            }
            else
            {
                try
                {
                    voziloRepozitorij.AzurirajVozilo(VratiVozilo());
                    this.Close();
                }
                catch (System.FormatException)
                {
                    lblError.Text="Nisu ispravno unseni podaci!";
                }
            }
        }

    }
}
