using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TransportApp
{
    public partial class IspisRutaUC : UserControl
    {
        RutaRepozitorij rutarepozitorij = new RutaRepozitorij();

        public IspisRutaUC()
        {
            InitializeComponent();

            if(PrijavaForma.uloga == 3)
            {
                btnDodajRutu.Hide();
                btnIzbrišiRutu.Hide();
                btnAžurirajRutu.Hide();
                btnUnesiVrijemeDolaska.Location = new Point(420, 8);
            }
        }

        //Metoda učitava sve rute i prikazuje ih u datagridviewu
        public void Učitaj() 
        {
            dgvRute.DataSource = null;
            dgvRute.DataSource = rutarepozitorij.DohvatiRute();
        }

        //Metoda koja dohvaća selektiranu rutu iz datagridview-a i prosljeđuje ju formi DodajRutuFormi za ažuriranje
        private Ruta DohvatiSelektiranuRutu()
        {
            Ruta ruta = null;
            if (dgvRute.CurrentRow != null)
            {
                ruta = dgvRute.CurrentRow.DataBoundItem as Ruta;
                return ruta;
            }
            return null;
        }

        //Ako su u DodajRutuFormi popunjeni svi podaci i ispravni su, tada se poziva metoda DodajRutu iz RutaRepozitorij
        private void btnDodajRutu_Click(object sender, EventArgs e)
        {
            DodajRutuForma dodajrutuforma = new DodajRutuForma();
            dodajrutuforma.ShowDialog();
            Učitaj();
        }


        //Metoda koja briše selektiranu rutu
        private void btnIzbrišiRutu_Click(object sender, EventArgs e)
        {
            if (DohvatiSelektiranuRutu() != null)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        rutarepozitorij.ObrišiRutu(DohvatiSelektiranuRutu());
                        lblError.Text = "";
                        Učitaj();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        lblError.Text="Ne možete obrisati rutu jer postoji upisan zapisnik s ovom rutom!";
                    }
                }
                else
                {

                }
            }
            else
            {
                lblError.Text="Nije odabrana ni jedna ruta!";
            }
        }

        //Ako su u DodajRutuFormi popunjeni svi podaci i ispravni su, tada se poziva metoda AzurirajRutu iz RutaRepozitorij
        private void btnAžurirajRutu_Click(object sender, EventArgs e)
        {
            if (DohvatiSelektiranuRutu() != null)
            {
                DodajRutuForma dodajrutuforma = new DodajRutuForma(DohvatiSelektiranuRutu());
                dodajrutuforma.ShowDialog();
                lblError.Text = "";
                Učitaj();
            }
            else lblError.Text="Nije odabrana ni jedna ruta!";
        }

        private void btnUnesiVrijemeDolaska_Click(object sender, EventArgs e)
        {
            if(DohvatiSelektiranuRutu()!=null)
            {
                rutarepozitorij.PotvrdiDolazak(DohvatiSelektiranuRutu());
                Učitaj();
                lblError.Text = "";
            }
            else lblError.Text = "Nije odabrana ni jedna ruta!";
        }

        private void btnUcitajPodatke_Click(object sender, EventArgs e)
        {
            Učitaj();
        }
    }
}
