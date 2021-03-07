using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public static class Validacija
    {

        // metoda koja dohvaća listu zaposlenika od klase ZaposlenikRepozitorij i ako su podaci ispravni vraća prijavljenog zaposlenika
        // ako su podaci neispravni vraća null
       public static Zaposlenik IzvrsiPrijavu(string korisnickoIme, string lozinka)
        {
            ZaposlenikRepozitorij repozitorij = new ZaposlenikRepozitorij();
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika = repozitorij.DohvatiZaposlenike(); 
            return ValidirajPodatke(korisnickoIme, lozinka, listaZaposlenika);
         }

        //metoda koja traži zaposlenika s unesenim koricničim imenom u listi zaposlenika i provjerava točnost lozinke
        public static Zaposlenik ValidirajPodatke(string korisnickoIme, string lozinka, List<Zaposlenik> listaZaposlenika)
        {
            Zaposlenik validiraniZaposlenik = null;
            validiraniZaposlenik = listaZaposlenika.Find(item => item.KorisnickoIme == korisnickoIme);
            if(validiraniZaposlenik != null)
            {
                if (validiraniZaposlenik.Lozinka == lozinka)
                {
                    return validiraniZaposlenik;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public static string ProvjeraUnosaZaposlenika(Zaposlenik zaposlenik, Zaposlenik stariZaposlenik)
        {
            ZaposlenikRepozitorij repozitorij = new ZaposlenikRepozitorij();
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika = repozitorij.DohvatiZaposlenike();
            string error = "";
            if (stariZaposlenik == null)
            {
                if (zaposlenik.OIB.Length != 13)
                {
                    error += "OIB mora imati 13 znakova!\n";
                }
                else if (listaZaposlenika.Find(item => item.OIB == zaposlenik.OIB) != null)
                {
                    error += "Korisnik s unesenim OIB-om već postoji\n";
                }
                
            }
            if (zaposlenik.KorisnickoIme.Length < 1)
            {
                error += "Unesite korisničko ime!\n";
            }
            else if (listaZaposlenika.Find(item => item.KorisnickoIme == zaposlenik.KorisnickoIme) != null /*&& zaposlenik.KorisnickoIme!=stariZaposlenik.KorisnickoIme*/)
            {
                error += "Korisnik s unesenim korisničkim imenom već postoji!\n";
            }
            if (zaposlenik.Ime.Length < 1)
            {
                error += "Unesite ime!\n";
            }
            if (zaposlenik.Prezime.Length < 1)
            {
                error += "Unesite Prezime!\n";
            }
            if (zaposlenik.StrucnaSprema.Length < 1)
            {
                error += "Unesite stručnu spremu!\n";
            }
            if (zaposlenik.Adresa.Length < 1)
            {
                error += "Unesite adresu!\n";
            }
            if (zaposlenik.BrojTelefona.Length < 1)
            {
                error += "Unesite broj telefona!\n";
            }
            if (zaposlenik.Email.Length < 1)
            {
                error += "Unesite email!\n";
            }
           
            if (zaposlenik.Lozinka.Length < 1)
            {
                error += "Unesite lozinku!\n";
            }
            return error;
        }

        public static string ProvjeraKorisnickogImena(string staroKorisnickoIme, string korisnickoIme)
        {
            ZaposlenikRepozitorij repozitorij = new ZaposlenikRepozitorij();
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika = repozitorij.DohvatiZaposlenike();
            string error = "";
            if (korisnickoIme.Length < 1)
            {
                error += "Unesite korisničko ime!\n";
            }
            else if (listaZaposlenika.Find(item => item.KorisnickoIme == korisnickoIme) != null /*&& korisnickoIme != staroorisnickoIme*/)
            {
                error += "Korisnik s unesenim korisničkim imenom već postoji!\n";
            }
            return error;
        }

        public static string ProvjeraLozinke(string lozinka, string potvrdaLozinke)
        {
            string error = "";
            if (lozinka.Length < 1)
            {
                error += "Unesite lozinku!\n";
            }
            else if (lozinka != potvrdaLozinke)
            {
                error += "Lozinke nisu jednake!\n";
            }
            return error;
        }
    }
}
