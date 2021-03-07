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
    public partial class Izvještaj : Form
    {
        RutaRepozitorij rutaRepozitorij = new RutaRepozitorij();
        VoziloRepozitorij voziloRepozitorij = new VoziloRepozitorij();
        ZaposlenikRepozitorij zaposlenikRepozitorij = new ZaposlenikRepozitorij();
        ZapisnikRepozitorij zapisnikRepozitorij = new ZapisnikRepozitorij();
        public Izvještaj()
        {
            InitializeComponent();
        }

        private void Izvještaj_Load(object sender, EventArgs e)
        {
            List<Ruta> rute = rutaRepozitorij.DohvatiRute();
            RutaBindingSource.DataSource = rute;
            List<Vozilo> vozila = voziloRepozitorij.DohvatiVozila();
            VoziloBindingSource.DataSource = vozila;
            List<Zaposlenik> zaposlenik = zaposlenikRepozitorij.DohvatiZaposlenike();
            ZaposlenikBindingSource.DataSource=zaposlenik;
            List<Zapisnik> zapisnici = zapisnikRepozitorij.DohvatiZapisnike();
            ZapisnikBindingSource.DataSource = zapisnici;

            
            this.reportViewer1.RefreshReport();
        }
    }
}
