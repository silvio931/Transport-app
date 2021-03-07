using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp
{
    public partial class DodajZaposlenikaForma : Form
    {
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        Zaposlenik stariZaposlenik;
        Tvrtka tvrtka;
        Tvrtka tvrtkaZaAdministratora;
        // konstruktor za dodavanje novog zaposlenika
        public DodajZaposlenikaForma()
        {
            InitializeComponent();
            cmbUloga.DataSource = zaposlenikRepozitorij.DohvatiUlogeZaposlenikaZaZaposlenike();
            tvrtka = PrijavaForma.prijavljeniZaposlenik.Tvrtka;
            
        }
        // konstruktor za ažuriranje zaposlenika, trenutni zaposlenik je odabrani zaposlenik u data grid viewu na IspisZaposlenikaUC
        // polja će se popuniti njegovim informacijama i mogu se mijenjati i spremiti
        public DodajZaposlenikaForma(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            stariZaposlenik = zaposlenik;
            cmbUloga.DataSource = zaposlenikRepozitorij.DohvatiUlogeZaposlenika();
            tvrtka = PrijavaForma.prijavljeniZaposlenik.Tvrtka;
            
        }
        public DodajZaposlenikaForma(Tvrtka trenutnaTvrtka)
        {
            InitializeComponent();
            cmbUloga.DataSource = zaposlenikRepozitorij.DohvatiUlogeZaposlenika();
            tvrtkaZaAdministratora = trenutnaTvrtka;
            tvrtka = trenutnaTvrtka;
        }

        // metoda koja vraća zaposlenika u kojeg su pohranjeni svi podaci kontroli IspisVozilaUC koja na prisitak tipke Spremi zatvara formu
        // i pomoću klase ZaposlenikRepozitorij dodaje novog zaposlenika u bazu
        public Zaposlenik VratiZaposlenika()
        {
            Uloga uloga = cmbUloga.SelectedItem as Uloga;
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik.OIB = txtOib.Text;
            zaposlenik.Uloga = uloga;
            zaposlenik.Ime = txtIme.Text;
            zaposlenik.Prezime = txtPrezime.Text;
            zaposlenik.StrucnaSprema = txtStrucnaSprema.Text;
            zaposlenik.DatumZaposlenja = dtpDatumZaposlenja.Value;
            zaposlenik.BrojTelefona = txtBrojTelefona.Text;
            zaposlenik.Adresa = txtAdresa.Text;
            zaposlenik.Email = txtEmail.Text;
            zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.Lozinka = txtLozinka.Text;
            zaposlenik.Tvrtka = tvrtka;
            return zaposlenik;
        }
        
        private void DodajZaposlenikaForma_Load(object sender, EventArgs e)
        {
            
            if (tvrtkaZaAdministratora != null)
            {
                cmbUloga.SelectedIndex = 0;
                cmbUloga.Enabled = false;
                this.Text = "Dodaj administratora";
            }
            else if (stariZaposlenik != null)
            {
                txtOib.ReadOnly = true;
                cmbUloga.Enabled = false;
                txtOib.Text = stariZaposlenik.OIB;
                cmbUloga.SelectedIndex = stariZaposlenik.Uloga.Uloga_id - 1;
                txtIme.Text = stariZaposlenik.Ime;
                txtPrezime.Text = stariZaposlenik.Prezime;
                txtStrucnaSprema.Text = stariZaposlenik.StrucnaSprema;
                dtpDatumZaposlenja.Value = stariZaposlenik.DatumZaposlenja;
                txtAdresa.Text = stariZaposlenik.Adresa;
                txtBrojTelefona.Text = stariZaposlenik.BrojTelefona;
                txtEmail.Text = stariZaposlenik.Email;
                txtKorisnickoIme.Text = stariZaposlenik.KorisnickoIme;
                txtLozinka.Text = stariZaposlenik.Lozinka;
                
            }
            
            
            
        }
        // metoda koja zatvara formu
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // metoda koja sprema podatke u bazu i zatvara formu
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string validacija = Validacija.ProvjeraUnosaZaposlenika(VratiZaposlenika(), stariZaposlenik);
            if (validacija.Length>0)
            {
                lblError.Text = validacija;
            }
            else
            {
                if (stariZaposlenik == null)
                {
                    zaposlenikRepozitorij.DodajZaposlenika(VratiZaposlenika());
                }
                else
                {
                    zaposlenikRepozitorij.AzurirajZaposlenika(VratiZaposlenika());
                }
                this.Close();
            }
        }
    }
}
