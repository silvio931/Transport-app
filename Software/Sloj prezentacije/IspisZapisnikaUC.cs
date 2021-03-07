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
    public partial class IspisZapisnikaUC : UserControl
    {
        ZapisnikRepozitorij zapisnikRepozitorij = new ZapisnikRepozitorij();

        public IspisZapisnikaUC()
        {
            InitializeComponent();


            if(PrijavaForma.uloga == 2)
            {
                btnDodajZapisnik.Hide();
                btnAžurirajZapisnik.Hide();
                btnObrađenNeobrađen.Location = new Point(420, 8);
            }
            if (PrijavaForma.uloga == 3)
            {
                btnObrađenNeobrađen.Hide();
            }
        }

        //Metoda učitava sve zapisnike i prikazuje ih u datagridview
        public void Ucitaj()
        {
            dgvZapisnici.DataSource = null;
            dgvZapisnici.DataSource = zapisnikRepozitorij.DohvatiZapisnike();
            dgvZapisnici.Columns[0].HeaderText = "Zapisnik ID";
            dgvZapisnici.Columns[1].HeaderText = "Ruta ID";
            dgvZapisnici.Columns[2].HeaderText = "Opis zapisnika";
            dgvZapisnici.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvZapisnici.Columns[3].HeaderText = "Vrijeme kreiranja";
            dgvZapisnici.Columns[4].HeaderText = "Zapisnik obrađen";
        }

        //Metoda koja dohvaća selektirani zapisnik iz datagridview-a i prosljeđuje ga formi DodajZapisnikForma za ažuriranje
        public Zapisnik DohvatiSelektiraniZapisnik()
        {
            Zapisnik zapisnik = null;
            if (dgvZapisnici.CurrentRow != null)
            {
                zapisnik = dgvZapisnici.CurrentRow.DataBoundItem as Zapisnik;
                zapisnik.ListaGreski = zapisnikRepozitorij.DohvatiGreskeZapisnika(zapisnik.Zapisnik_id);
                return zapisnik;
            }
            return null;
        }

        //Ako su u DodajZapisnikForma popunjeni svi podaci i ispravni su, tada se poziva metoda DodajZapisnik iz ZapisnikRepozitorij
        private void btnDodajZapisnik_Click(object sender, EventArgs e)
        {
            DodajZapisnikForma forma = new DodajZapisnikForma();
            forma.ShowDialog();
            Ucitaj();
        }

        //Ako su u DodajZapisnikForma popunjeni svi podaci i ispravni su, tada se poziva metoda AzurirajZapisnik iz ZapisnikRepozitorij
        private void btnAžurirajZapisnik_Click(object sender, EventArgs e)
        {
            if (DohvatiSelektiraniZapisnik() == null)
            {
                lblError.Text="Nije odabran ni jedan zapisnik!";
            }
            else
            {
                DodajZapisnikForma forma = new DodajZapisnikForma(DohvatiSelektiraniZapisnik());
                forma.ShowDialog();
                lblError.Text = "";
                Ucitaj();
            }
        }

        private void btnIzbrišiZapisnik_Click(object sender, EventArgs e)
        {
            if (DohvatiSelektiraniZapisnik() == null)
            {
                lblError.Text = "Nije odabran ni jedan zapisnik!";
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    zapisnikRepozitorij.ObrisiZapisnikGreske(DohvatiSelektiraniZapisnik());
                    zapisnikRepozitorij.ObrisiZapisnik(DohvatiSelektiraniZapisnik());
                    Ucitaj();
                    lblError.Text = "";

                }
            else
                {

                }
            }
        }

        //Klikom na gumb odabrani zapisnik može se označiti kao obrađen ili neobrađen
        private void btnObrađenNeobrađen_Click(object sender, EventArgs e)
        {
            try
            {
                zapisnikRepozitorij.PromijeniStatusZapisnika(DohvatiSelektiraniZapisnik());
                lblError.Text = "";
            }
            catch (System.NullReferenceException)
            {
                lblError.Text = "Nije odabran ni jedan zapisnik!";
            }
            Ucitaj();
        }

        //Klikom na određeni zapisnik u dgvGreske ispisuju se sve greške iz odabranog zapisnika
        private void dgvZapisnici_SelectionChanged(object sender, EventArgs e)
        {
            Zapisnik zapisnik = DohvatiSelektiraniZapisnik();

            dgvGreske.DataSource = null;
            dgvGreske.DataSource = zapisnikRepozitorij.DohvatiGreskeZapisnika(zapisnik.Zapisnik_id);
            dgvGreske.Columns[0].HeaderText = "Greška ID";
            dgvGreske.Columns[1].HeaderText = "Naziv greške";
            dgvGreske.Columns[2].HeaderText = "Opis greške";
            dgvGreske.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (zapisnik.Obrađen == "Da")
            {
                btnAžurirajZapisnik.Enabled = false;
                btnIzbrišiZapisnik.Enabled = false;
            }
            if(zapisnik.Obrađen == "Ne")
            {
                btnAžurirajZapisnik.Enabled = true;
                btnIzbrišiZapisnik.Enabled = true;
            }
        }

        private void btnUcitajPodatke_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
