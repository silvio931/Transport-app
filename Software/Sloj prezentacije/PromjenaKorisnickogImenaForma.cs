using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class PromjenaKorisnickogImenaForma : Form
    {
        Zaposlenik zaposlenik;
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        public PromjenaKorisnickogImenaForma(Zaposlenik prijavljeniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = prijavljeniZaposlenik;
            
        }
        




        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string validacija = Validacija.ProvjeraKorisnickogImena(zaposlenik.KorisnickoIme, txtNovoKorisnickoIme.Text);
            if (validacija.Length > 0)
            {
                lblError.Text = validacija;
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni da želite promijeniti korisničko ime u '"+ txtNovoKorisnickoIme.Text +"'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        zaposlenikRepozitorij.AzurirajKorisnickoIme(zaposlenik.OIB, txtNovoKorisnickoIme.Text);
                        this.DialogResult=DialogResult.OK;
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
