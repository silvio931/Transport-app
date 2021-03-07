using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp
{
    public class Zaposlenik
    {
        public string OIB { get; set; }
        public Uloga Uloga { get; set; }
        
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Stručna sprema")]
        public string StrucnaSprema { get; set; }
        [DisplayName("Datum zaposlenja")]
        public DateTime DatumZaposlenja { get; set; }
        [DisplayName("Broj telefona")]
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }

        public string Lozinka { get; set; }
        [DisplayName("Korisničko ime")]
        public string KorisnickoIme { get; set; }
        public Tvrtka Tvrtka { get; set; }

        public Zaposlenik() { }
        public Zaposlenik(string oib, Uloga uloga, string ime, string prezime, string strucnaSprema, DateTime datumZaposlenja, string brojTelefona, string adresa, string email, string lozinka, string korisnickoIme, Tvrtka tvrtka)
        {
            OIB = oib;
            Uloga = uloga;
            Ime = ime;
            Prezime = prezime;
            StrucnaSprema = strucnaSprema;
            DatumZaposlenja = datumZaposlenja;
            BrojTelefona = brojTelefona;
            Adresa = adresa;
            Email = email;
            Lozinka = lozinka;
            KorisnickoIme = korisnickoIme;
            Tvrtka = tvrtka;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
