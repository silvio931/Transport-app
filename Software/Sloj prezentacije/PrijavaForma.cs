using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TransportApp
{
    public partial class PrijavaForma : Form
    {
        static string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        string path2 = path + "\\Software\\Resources\\Korisnicka_dokumentacija.chm";
        public PrijavaForma()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = path2;

        }

        public static int uloga;
        public static string oib;
        public static Zaposlenik prijavljeniZaposlenik;
        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPassword.Checked)
            {
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik = Validacija.IzvrsiPrijavu(txtBoxUsername.Text, txtBoxPassword.Text);
            if (zaposlenik != null)
            {
                uloga = zaposlenik.Uloga.Uloga_id;
                oib = zaposlenik.OIB;
                prijavljeniZaposlenik = zaposlenik;
                this.Hide();
                GlavnaForma glavnaforma = new GlavnaForma(zaposlenik);
                glavnaforma.Show();
            }
            else
            {
                txtBoxPassword.Text = "";
                txtBoxUsername.Text = "";
                lblError.Text="Neispravni podaci!";
                
            }
                    
        }

        //Zatvaranjem forme za prijavu zatvara aplikaciju i zatvara konekciju s bazom
        private void PrijavaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            Database.Instance.CloseConnection();
        }
    }
}
