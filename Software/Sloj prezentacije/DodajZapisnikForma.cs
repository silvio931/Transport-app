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
    public partial class DodajZapisnikForma : Form
    {
        RutaRepozitorij rutaRepozitorij = new RutaRepozitorij();
        Zapisnik stariZapisnik = null;
        ZapisnikRepozitorij zapisnikRepozitorij = new ZapisnikRepozitorij();

        //Konstruktor koji se koristi kada se dodaje novi zapisnik
        public DodajZapisnikForma()
        {
            InitializeComponent();
            Ucitaj();
        }

        private void DodajZapisnikForma_Load(object sender, EventArgs e)
        {

        }

        private void Ucitaj()
        {
            foreach (var item in zapisnikRepozitorij.DohvatiGreske())
            {
                clbGreske.Items.Add(item.naziv);
            }

            cmbRuta.DataSource = rutaRepozitorij.DohvatiRuteZaZapisnik();
        }

        //Konstruktor koji se poziva kod ažuriranja, prima parametar zapisnik koje se dohvaća iz kontrole IspisZapisnikaUC pomoću metode 
        //DohvatiSelektiraniZapisnik, i zatim podatke o tom zapisniku stavlja unutar textboxeva itd. u formi koji se mogu mijenjati
        public DodajZapisnikForma(Zapisnik zapisnik)
        {
            InitializeComponent();
            Ucitaj();
            stariZapisnik = zapisnik;
            cmbRuta.SelectedText = stariZapisnik.Ruta_id.ToString();
            txtOpisGreške.Text = stariZapisnik.Opis;

            List<Greska> lista = stariZapisnik.ListaGreski;
            List<Greska> sveGreske = new List<Greska>();
            for (int i = 0; i < clbGreske.Items.Count; i++)
            {
                sveGreske.Add(zapisnikRepozitorij.DohvatiGreskuPremaNazivu(clbGreske.Items[i].ToString()));
            }
            int j = 0;
                foreach (var item in sveGreske)
                {
                    if (lista.Contains(item))
                    {
                        clbGreske.SetItemChecked(j, true);
                    }
                j++;   
            }

            
        }

        //Metoda koja vraća zapisnik u koje su pohranjeni svi podaci kontroli IspiszapisnikaUC koja na prisitak tipke Dodaj nakon zatvaranja
        //DodajZapisnikaForma i zatim se pomoću klase ZapisnikRepozotorij upisuje novi zapisnik u bazu
        public Zapisnik VratiZapisnik()
        {
            Zapisnik zapisnik = new Zapisnik();
            if (stariZapisnik != null)
            {
                zapisnik.Zapisnik_id = stariZapisnik.Zapisnik_id;
            }
            zapisnik.Ruta_id = int.Parse(cmbRuta.SelectedItem.ToString());
            zapisnik.Opis = txtOpisGreške.Text;

            List<Greska> listaGreski = new List<Greska>();
            foreach (var item in clbGreske.CheckedItems)
            {
                listaGreski.Add(zapisnikRepozitorij.DohvatiGreskuPremaNazivu(item.ToString()));
            }

            zapisnik.ListaGreski = listaGreski;
            zapisnik.Obrađen = "Ne";

            return zapisnik;
        }

        //Pritisak na ovu tipku će u novo kreirani zapisnik upisivati podatke, te će IspisZapisnikaUC te podatke dohvaćati
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (clbGreske.SelectedItem == null || cmbRuta.SelectedItem == null || txtOpisGreške.Text == "")
            {
                lblError.Text="Podaci nisu ispravno unseni!";
            }
            else
            {
                if (stariZapisnik == null)
                {
                    zapisnikRepozitorij.DodajZapisnik(VratiZapisnik());
                    zapisnikRepozitorij.DodajZapisnikGreske(VratiZapisnik());
                    this.Close();
                }
                else
                {
                    zapisnikRepozitorij.ObrisiZapisnikGreske(stariZapisnik);
                    zapisnikRepozitorij.AzurirajZapisnik(VratiZapisnik());
                    zapisnikRepozitorij.AzurirajZapisnikGreske(VratiZapisnik());
                    this.Close();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
