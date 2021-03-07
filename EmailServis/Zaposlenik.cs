using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EmailServis
{
    public class Zaposlenik
    {
        public string OIB { get; set; }
        public Uloga Uloga { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string StrucnaSprema { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }

        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }

        public Zaposlenik() { }
        public Zaposlenik(string oib, Uloga uloga, string ime, string prezime, string strucnaSprema, DateTime datumZaposlenja, string brojTelefona, string adresa, string email, string lozinka, string korisnickoIme)
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
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
