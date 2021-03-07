using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace TransportApp
{
    public partial class EmailUC : UserControl
    {


          ServiceController service = null;

        public EmailUC()
        {
            
                InitializeComponent();

            if (PrijavaForma.uloga == 1)
            {
                ServiceController service = new ServiceController("SendMailService");
                OsvjeziGumbe();
            }

        }

        //Pokreće windows service za slanje e-mailova
        private void btnPokreniServis_Click(object sender, EventArgs e)
        {
            if (PrijavaForma.uloga == 1)
            {
                try
                {
                    service.Start();
                    MessageBox.Show("Servis pokrenut!");
                    OsvjeziGumbe();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Da biste pokrenuli servis, aplikaciju morate pokrenuti kao administrator.");
                }
            }

        }

        //Zaustavlja windows service za slanje e-mailova
        private void btnZaustaviServis_Click(object sender, EventArgs e)
        {
            if (PrijavaForma.uloga == 1)
            {
                try
                {
                    service.Stop();
                    MessageBox.Show("Servis zaustavljen!");
                    OsvjeziGumbe();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Da biste zaustavili servis, aplikaciju morate pokrenuti kao administrator.");
                }
            }
        }

        private void OsvjeziGumbe()
        {
            if (PrijavaForma.uloga == 1)
            {
                service = null;
                service = new ServiceController("SendMailService");
                try
                {
                    if (service.Status.Equals(ServiceControllerStatus.Running))
                    {
                        btnPokreniServis.Enabled = false;
                        btnZaustaviServis.Enabled = true;
                        lblStanje.Text = "Windows servis za slanje e-mailova trenutno je pokrenut.";
                    }
                    if (service.Status.Equals(ServiceControllerStatus.Stopped))
                    {
                        btnPokreniServis.Enabled = true;
                        btnZaustaviServis.Enabled = false;
                        lblStanje.Text = "Windows servis za slanje e-mailova trenutno je zaustavljen.";
                    }
                }
                catch (System.InvalidOperationException)
                {
                    btnPokreniServis.Enabled = false;
                    btnZaustaviServis.Enabled = false;
                    lblStanje.Text = "Windows servis za slanje e-mailova nije instaliran na ovom računalu.";
                }
            }
        }
    }
}
