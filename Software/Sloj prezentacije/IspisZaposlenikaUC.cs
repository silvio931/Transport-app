using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class IspisZaposlenikaUC : UserControl
    {
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        public IspisZaposlenikaUC()
        {
            InitializeComponent();

            if (PrijavaForma.uloga == 2)
            {
                btnDodajZaposlenika.Hide();
                btnAžurirajZaposlenika.Hide();
                btnIzbrišiZaposlenika.Hide();
            }
        }

        // metoda koja ucitava sva vozila u data grid view
        public void Ucitaj() {
            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = zaposlenikRepozitorij.DohvatiZaposlenikeTvrtke();
            dgvZaposlenici.Columns[11].Visible = false;
        }

        //metoda koja dohvaca zaposlenika selektiranog u data grid view-u
        private Zaposlenik DohvatiSekeltiranogZaposlenika()
        {
            Zaposlenik zaposlenik;
            if (dgvZaposlenici.CurrentRow != null)
            {
                zaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
                return zaposlenik;
            }
            return null;

        }
        // metoda koja otvara formu za dodavanje novog zaposlenika
        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForma dodajZaposlenikaForma = new DodajZaposlenikaForma();
            dodajZaposlenikaForma.ShowDialog();
            Ucitaj();
        }
        // metoda koja brise odabranog zaposlenika
        private void btnIzbrišiZaposlenika_Click(object sender, EventArgs e)
        {
            if (DohvatiSekeltiranogZaposlenika() == null)
            {
                lblError.Text="Nije odabran ni jedan zaposlenik!";
            }
            else if (DohvatiSekeltiranogZaposlenika().Uloga.Uloga_id == 1)
            {
                lblError.Text="Ne možete obrisati administratora!";
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        zaposlenikRepozitorij.ObrisiZaposlenika(DohvatiSekeltiranogZaposlenika());
                        lblError.Text = "";
                        Ucitaj();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        lblError.Text="Ne možete obrisati zaposlenika jer postoji upisana ruta s ovim zaposlenikom!";
                    }
                }
            }
        }
        private void btnAžurirajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForma azurirajZaposlenikaForma = new DodajZaposlenikaForma(DohvatiSekeltiranogZaposlenika());
            azurirajZaposlenikaForma.ShowDialog();
            Ucitaj();
        }

        private void IspisZaposlenikaUC_Load(object sender, EventArgs e)
        {

        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
