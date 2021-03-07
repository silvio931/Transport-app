using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace TransportApp
{
    public partial class ProfilUC : UserControl
    {
        Zaposlenik zaposlenik = PrijavaForma.prijavljeniZaposlenik;
        RutaRepozitorij rutaRepozitorij = new RutaRepozitorij();
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        public ProfilUC()
        {
            InitializeComponent();
            
        }

        // metoda koja izračunava trajanje zaposlenja na temelju početka zaposlenja
        public string IzracunajVrijemeTrajanjaZaposlenja(DateTime pocetakZaposlenja)
        {
            double dani = (DateTime.Today - pocetakZaposlenja).TotalDays;
            string trajanje = dani.ToString();
            return trajanje;
        }

        private void ProfilUC_Load(object sender, EventArgs e)
        {

        }
        // popuni polja podacima
        private void IspisiInfo()
        {
            txtTrajanje.Text = IzracunajVrijemeTrajanjaZaposlenja(zaposlenik.DatumZaposlenja);
        }

        // metoda koja otvara formu za promjenu lozinke
        private void btnPromjenaLozinke_Click(object sender, EventArgs e)
        {
            PromjenaLozinkeForma promjenaLozinkeForma = new PromjenaLozinkeForma(zaposlenik);
            DialogResult dr=promjenaLozinkeForma.ShowDialog();
            ZatvoriFormu(dr);
        }
        // metoda koja otvara formu za promjenu korisnickog imena
        private void btnPromijeniKorisnickoIme_Click(object sender, EventArgs e)
        {
            // kad bude prijava implementirana trebalo bi proslijediti prijavljenog zaposlenika 
            // koji bude proslijeden od forme prijava glavnoj formi 
            PromjenaKorisnickogImenaForma promjenaKorisnickogImenaForma = new PromjenaKorisnickogImenaForma(zaposlenik);
            DialogResult dr=promjenaKorisnickogImenaForma.ShowDialog();
            ZatvoriFormu(dr);


        }
        private void ZatvoriFormu(DialogResult dr)
        {
            if (dr == DialogResult.OK)
            {
                Database.Instance.CloseConnection();
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btnUcitajPodatke_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = PrijavaForma.prijavljeniZaposlenik;
            txtOib.Text = zaposlenik.OIB;
            txtUloga.Text = zaposlenik.Uloga.Naziv;
            txtIme.Text = zaposlenik.Ime;
            txtPrezime.Text = zaposlenik.Prezime;
            txtStrucnaSprema.Text = zaposlenik.StrucnaSprema;
            txtAdresa.Text = zaposlenik.Adresa;
            txtBrojTelefona.Text = zaposlenik.BrojTelefona;
            txtEmail.Text = zaposlenik.Email;
            txtLozinka.Text = zaposlenik.Lozinka;
            txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;
            dtpDatumZaposlenja.Value = zaposlenik.DatumZaposlenja;
            IspisiInfo();
        }
    }
}
