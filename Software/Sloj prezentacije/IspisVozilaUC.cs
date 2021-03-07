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
    public partial class IspisVozilaUC : UserControl
    {
        VoziloRepozitorij voziloRepozitorij = new VoziloRepozitorij();

        public IspisVozilaUC()
        {
            InitializeComponent();

            if (PrijavaForma.uloga == 2)
            {
                btnDodajVozilo.Hide();
                btnAžurirajVozilo.Hide();
                btnIzbrišiVozilo.Hide();
            }
        }

        //Metoda učitava sva vozila i prikazuje ih u datagridview
        public void Ucitaj()
        {
            dgvVozila.DataSource = null;
            dgvVozila.DataSource = voziloRepozitorij.DohvatiVozila();
            dgvVozila.Columns[5].Visible = false;
            dgvVozila.Columns[0].HeaderText = "Registracija";
            dgvVozila.Columns[1].HeaderText = "Vrsta vozila";
            dgvVozila.Columns[2].HeaderText = "Marka";
            dgvVozila.Columns[3].HeaderText = "Godina proizvodnje";
            dgvVozila.Columns[4].HeaderText = "Nosivost";
        }

        //Metoda koja dohvaća selektirano vozilo iz datagridview-a i prosljeđuje ga formi DodajVoziloForma za ažuriranje
        private Vozilo DohvatiSelektiranoVozilo()
        {
            Vozilo vozilo;
            if(dgvVozila.CurrentRow != null)
            {
                vozilo = dgvVozila.CurrentRow.DataBoundItem as Vozilo;
                return vozilo;
            }
            return null;
        }

       

        //Ako su u DodajVoziloForma popunjeni svi podaci i ispravni su, tada se poziva metoda DodajVozilo iz VoziloRepozitorij
        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            DodajVoziloForma forma = new DodajVoziloForma();
            forma.ShowDialog();
            Ucitaj();
        }

        //Ako su u DodajVoziloForma popunjeni svi podaci i ispravni su, tada se poziva metoda AzurirajVozilo iz VoziloRepozitorij
        private void btnAžurirajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                DodajVoziloForma forma = new DodajVoziloForma(DohvatiSelektiranoVozilo());
                forma.ShowDialog();
                Ucitaj();
                lblError.Text = "";
            }
            catch (System.NullReferenceException)
            {
                lblError.Text = "Nije odabrano ni jedno vozilo!";
            }
        }
        
        //Kod brisanja najprije pita korisnika je li siguran da želi obrisati odabrani zapis, zatim provjerava je li stvarno odabrano neko vozilo
        //i ako je provjerava baca li iznimku da se vozilo ne može obrisati jer je upisano u nekoj ruti
        private void btnIzbrišiVozilo_Click(object sender, EventArgs e)
        {
            if (DohvatiSelektiranoVozilo() == null)
            {
                lblError.Text="Nije odabrano ni jedno vozilo!";
            }
            else
            {
            if (MessageBox.Show("Jeste li sigurni?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    voziloRepozitorij.ObrisiVozilo(DohvatiSelektiranoVozilo());
                    lblError.Text = "";
                    Ucitaj();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    lblError.Text="Ne možete obrisati vozilo jer postoji upisana ruta s ovim vozilom!";
                }
            }
            else
             {
               }
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
