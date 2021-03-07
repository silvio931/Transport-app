using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Ruta
    {
        public int Ruta_id { get; set; }
        public string Zaposlenik_id { get; set; }
        public string Kreirao { get; set; }
        public string Vozilo_registracija { get; set; }
        public string Broj_otpremnice { get; set; }
        public string Polazište { get; set; }
        public string Odredište { get; set; }
        public string Datum_i_vrijeme_polaska { get; set; }
        public string Očekivano_vrijeme_dolaska { get; set; }
        public string Stvarno_vrijeme_dolaska { get; set; }
        
        public Ruta()
        {

        }
        
        public Ruta(int ruta_id, string zaposlenik_id,string kreirao, string vozilo_registracija, string broj_otpremnice, string polazište, 
                    string odredište, string datum_i_vrijeme_polaska, string očekivano_vrijeme_dolaska, string stvarno_vrijeme_dolaska)
        {
            this.Ruta_id = ruta_id;
            this.Zaposlenik_id = zaposlenik_id;
            this.Kreirao = kreirao;
            this.Vozilo_registracija = vozilo_registracija;
            this.Broj_otpremnice = broj_otpremnice;
            this.Polazište = polazište;
            this.Odredište = odredište;
            this.Datum_i_vrijeme_polaska = datum_i_vrijeme_polaska;
            this.Očekivano_vrijeme_dolaska = očekivano_vrijeme_dolaska;
            this.Stvarno_vrijeme_dolaska = stvarno_vrijeme_dolaska;
        }

        public override string ToString()
        {
            return Ruta_id.ToString();
        }
    }
}
