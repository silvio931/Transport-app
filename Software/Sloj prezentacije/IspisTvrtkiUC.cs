using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportApp.Aplikacijski_sloj;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp.Sloj_prezentacije
{
    public partial class IspisTvrtkiUC : UserControl
    {
        TvrtkaRepozitorij tvrtkeRepozitorij = new TvrtkaRepozitorij();
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        public IspisTvrtkiUC()
        {
            InitializeComponent();
            Ucitaj();
            btnAdministrator.Hide();
            SakrijLabele();
        }

        private void ispisVozilaUC1_Load(object sender, EventArgs e)
        {

        }
        public void Ucitaj()
        {
            dgvTvrtke.DataSource = null;
            dgvTvrtke.DataSource = tvrtkeRepozitorij.DohvatiTvrtke();
        }
        private void btnKreirajTvrtku_Click(object sender, EventArgs e)
        {
            DodajTvrtkuForma dodajTvrtkuForma = new DodajTvrtkuForma();
            dodajTvrtkuForma.ShowDialog();
            Ucitaj();
        }

        private void btnAzirirajTvrtku_Click(object sender, EventArgs e)
        {


            DodajTvrtkuForma azurirajTvrtkuForma = new DodajTvrtkuForma(DohvatiSelektiranuTvrtku());
            azurirajTvrtkuForma.ShowDialog();
            Ucitaj();

        }

        private Tvrtka DohvatiSelektiranuTvrtku()
        {
            Tvrtka tvrtka;
            if (dgvTvrtke.CurrentRow != null)
            {
                tvrtka = dgvTvrtke.CurrentRow.DataBoundItem as Tvrtka;
                return tvrtka;
            }
            return null;

        }

        private void dgvTvrtke_SelectionChanged(object sender, EventArgs e)
        {
            Tvrtka odabranaTvrtka = DohvatiSelektiranuTvrtku();
            Zaposlenik administrator = DohvatiAdministratora(odabranaTvrtka);
            if (administrator == null)
            {
                btnAdministrator.Show();
                SakrijLabele();
            }
            else
            {
                btnAdministrator.Hide();
                PrikaziLabele();
                lblKorisnickoImeValue.Text = administrator.KorisnickoIme;
                lblLozinkaValue.Text = administrator.Lozinka;
            }
        }

        private Zaposlenik DohvatiAdministratora(Tvrtka tvrtka)
        {
            Zaposlenik administrator = null;
            List<Zaposlenik> listaZaposlenika = zaposlenikRepozitorij.DohvatiZaposlenike();
            administrator = listaZaposlenika.Find(item => item.Uloga.Uloga_id == 1 && item.Tvrtka.Tvrtka_id == tvrtka.Tvrtka_id);
            return administrator;
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForma dodajAdministratora = new DodajZaposlenikaForma(DohvatiSelektiranuTvrtku()) ;
            dodajAdministratora.ShowDialog();
            Ucitaj();
        }

        private void SakrijLabele()
        {
            lblKorisnickoIme.Hide();
            lblKorisnickoImeValue.Hide();
            lblLozinka.Hide();
            lblLozinkaValue.Hide();
        }

        private void PrikaziLabele()
        {
            lblKorisnickoIme.Show();
            lblKorisnickoImeValue.Show();
            lblLozinka.Show();
            lblLozinkaValue.Show();
        }
    }
}
