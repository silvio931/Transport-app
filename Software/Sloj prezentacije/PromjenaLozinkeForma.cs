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
    public partial class PromjenaLozinkeForma : Form
    {
        Zaposlenik zaposlenik;
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        public PromjenaLozinkeForma(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = prijavljeniZaposlenik;
        }

        // Metoda koja vraća zaposlenika u kojeg su pohranjeni svi podaci kontroli ProfilUC koja na prisitak tipke za azuriranje nakon zatvaranja
        // DodajZaposlenikaForma i zatim se pomoću klase ZaposlenikRepozotorij upisuje novi zaposlenik u bazu
        


        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string validacija = Validacija.ProvjeraLozinke(txtNovaLozinka.Text, txtPotvrdaLozinke.Text);
            if (validacija.Length > 0)
            {
                lblError.Text = validacija;
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni da želite promijeniti lozinku?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        zaposlenikRepozitorij.AzurirajLozinku(zaposlenik.OIB, txtNovaLozinka.Text);
                        MessageBox.Show("Vaša lozinka je uspješno promijenjena!", "Promjena lozinke");
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        lblError.Text="Korisničko ime je neispravno!";
                    }

                }

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
