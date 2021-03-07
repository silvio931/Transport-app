using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportApp.Aplikacijski_sloj;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp.Sloj_prezentacije
{
    public partial class DodajTvrtkuForma : Form
    {
        TvrtkaRepozitorij tvrtkaRepozitorij = new TvrtkaRepozitorij();
        Tvrtka staraTvrtka;
        public DodajTvrtkuForma()
        {
            InitializeComponent();
        }

        public DodajTvrtkuForma(Tvrtka tvrtka)
        {
            InitializeComponent();
            staraTvrtka = tvrtka;
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (staraTvrtka != null)
            {
                try
                {
                    tvrtkaRepozitorij.AzurirajTvrtku(VratiTvrtku());
                    MessageBox.Show("Tvrtka je uspješno ažurirana!");
                    this.Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Nisu ispravno unseni podaci!");
                }
            }
            else
            {
                try
                {
                    tvrtkaRepozitorij.DodajTvrtku(VratiTvrtku());
                    MessageBox.Show("Tvrtka je uspješno dodana!");
                    this.Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Nisu ispravno unseni podaci!");
                }
            }
            

        }

        public Tvrtka VratiTvrtku()
        {
            Tvrtka tvrtka = new Tvrtka();
            tvrtka.Naziv = txtNaziv.Text;
            tvrtka.Adresa = txtAdresa.Text;
            if (staraTvrtka != null)
            {
                tvrtka.Tvrtka_id = int.Parse(lblIdValue.Text);
            }
            
            return tvrtka;
        }

        private void DodajTvrtkuForma_Load(object sender, EventArgs e)
        {
            if (staraTvrtka != null)
            {
                this.Text = "Ažuriranje tvrtke";
                lblId.Text = "ID: ";
                lblIdValue.Text = staraTvrtka.Tvrtka_id.ToString();
                txtAdresa.Text = staraTvrtka.Adresa;
                txtNaziv.Text = staraTvrtka.Naziv;
            }
        }
    }
}
