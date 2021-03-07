using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Aplikacijski_sloj;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp
{
    public class ZaposlenikRepozitorij
    {
        List<Zaposlenik> ListaZaposlenika = new List<Zaposlenik>();

        public ZaposlenikRepozitorij()
        {

        }
        public Zaposlenik DohvatiZaposlenika(SqlDataReader dr, List<Uloga> listaUloga, List<Tvrtka> listaTvrtki)
        {
            Uloga uloga = null;
            Tvrtka tvrtka = null;
            Zaposlenik zaposlenik = null;
            if (dr != null)
            {
                uloga = new Uloga();
                tvrtka = new Tvrtka();
                zaposlenik = new Zaposlenik();
                zaposlenik.OIB = dr["oib"].ToString();
                zaposlenik.Ime = dr["ime"].ToString();
                zaposlenik.Prezime = dr["prezime"].ToString();
                zaposlenik.StrucnaSprema = dr["stručna_sprema"].ToString();
                zaposlenik.DatumZaposlenja = DateTime.Parse(dr["datum_zaposlenja"].ToString());
                zaposlenik.BrojTelefona = dr["broj_telefona"].ToString();
                zaposlenik.Adresa = dr["adresa"].ToString();
                zaposlenik.Email = dr["email"].ToString();
                zaposlenik.Lozinka = dr["lozinka"].ToString();
                zaposlenik.Uloga = listaUloga.Find(item => item.Uloga_id == int.Parse(dr["uloga_id"].ToString())); ;
                zaposlenik.KorisnickoIme = dr["korisničko_ime"].ToString();
                zaposlenik.Tvrtka = listaTvrtki.FirstOrDefault(item => item.Tvrtka_id == int.Parse(dr["tvrtka_id"].ToString()));
               
            }
            return zaposlenik;
        }

        public Zaposlenik DohvatiZaposlenikaRuta(SqlDataReader dr)
        {
            Uloga uloga = null;
            Zaposlenik zaposlenik = null;
            if (dr != null)
            {
                uloga = new Uloga();
                zaposlenik = new Zaposlenik();
                zaposlenik.OIB = dr["oib"].ToString();
                zaposlenik.Ime = dr["ime"].ToString();
                zaposlenik.Prezime = dr["prezime"].ToString();
                zaposlenik.StrucnaSprema = dr["stručna_sprema"].ToString();
                zaposlenik.DatumZaposlenja = DateTime.Parse(dr["datum_zaposlenja"].ToString());
                zaposlenik.BrojTelefona = dr["broj_telefona"].ToString();
                zaposlenik.Adresa = dr["adresa"].ToString();
                zaposlenik.Email = dr["email"].ToString();
                zaposlenik.Lozinka = dr["lozinka"].ToString();
                zaposlenik.KorisnickoIme = dr["korisničko_ime"].ToString();
            }
            return zaposlenik;
        }

        // metoda koja dohvaća sve zaposlenike iz baze
        public List<Zaposlenik> DohvatiZaposlenike()
        {
            List<Uloga> listaUloga = new List<Uloga>();
            TvrtkaRepozitorij tvrtkaRepozitorij = new TvrtkaRepozitorij();
            List<Tvrtka> listaTvrtki = tvrtkaRepozitorij.DohvatiTvrtke();
            listaUloga = DohvatiUlogeZaposlenika();
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            string sqlUpit = $"SELECT * FROM zaposlenik";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenik zaposlenik = DohvatiZaposlenika(dr, listaUloga, listaTvrtki);
                listaZaposlenika.Add(zaposlenik);
            }
            dr.Close();
            return listaZaposlenika;
        }

        public List<Zaposlenik> DohvatiZaposlenikeTvrtke()
        {
            List<Uloga> listaUloga = new List<Uloga>();
            TvrtkaRepozitorij tvrtkaRepozitorij = new TvrtkaRepozitorij();
            List<Tvrtka> listaTvrtki = tvrtkaRepozitorij.DohvatiTvrtke();
            listaUloga = DohvatiUlogeZaposlenika();
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            string sqlUpit = $"SELECT * FROM zaposlenik WHERE tvrtka_id={PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id}";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenik zaposlenik = DohvatiZaposlenika(dr, listaUloga, listaTvrtki);
                listaZaposlenika.Add(zaposlenik);
            }
            dr.Close();
            return listaZaposlenika;
        }
        public List<Zaposlenik> DohvatiVozačeRuta()
        {
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            //string sqlUpit = $"SELECT * FROM zaposlenik left join ruta on zaposlenik.oib=ruta.zaposlenik_oib where '{DodajRutuForma.vrijemePolaska.ToString("yyyy-MM-dd HH:mm:ss")}' > očekivano_vrijeme_dolaska and '{DodajRutuForma.vrijemeDolaska.ToString("yyyy-MM-dd HH:mm:ss")}' > očekivano_vrijeme_dolaska";
            string sqlUpit = $"SELECT * from zaposlenik z where not exists ( select 1 from ruta r where '{DodajRutuForma.vrijemePolaska.ToString("yyyy-MM-dd HH:mm:ss")}' < r.očekivano_vrijeme_dolaska and '{DodajRutuForma.vrijemeDolaska.ToString("yyyy-MM-dd HH:mm:ss")}' > r.datum_i_vrijeme_polaska and zaposlenik_oib=oib) and uloga_id=3 and tvrtka_id={PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id}";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit); 
            while (dr.Read())
            {
                Zaposlenik zaposlenik = DohvatiZaposlenikaRuta(dr);
                listaZaposlenika.Add(zaposlenik);
            }
            dr.Close();
            return listaZaposlenika;
        }

        // metoda koja dodaje zaposlenika primljenog IspisZaposlenikaUC i dodaje ga u bazu
        public int DodajZaposlenika(Zaposlenik noviZaposlenik) {
            string datum = noviZaposlenik.DatumZaposlenja.ToString("yyyyMMdd");
            string sql = $"INSERT INTO zaposlenik (oib, uloga_id, ime, prezime, stručna_sprema, datum_zaposlenja, broj_telefona, adresa, email, lozinka, korisničko_ime, tvrtka_id) VALUES ({noviZaposlenik.OIB}, {noviZaposlenik.Uloga.Uloga_id}, '{noviZaposlenik.Ime}', '{noviZaposlenik.Prezime}', '{noviZaposlenik.StrucnaSprema}', '{datum}', '{noviZaposlenik.BrojTelefona}', '{noviZaposlenik.Adresa}', '{noviZaposlenik.Email}', '{noviZaposlenik.Lozinka}', '{noviZaposlenik.KorisnickoIme}', '{noviZaposlenik.Tvrtka.Tvrtka_id}')";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }
        // metoda koja prima zaposlenika od IspisZaposlenikaUC i azurira ga
        public int AzurirajZaposlenika(Zaposlenik zaposlenik) {
            string datum = zaposlenik.DatumZaposlenja.ToString("yyyyMMdd");
            string sql = $"UPDATE zaposlenik SET uloga_id={zaposlenik.Uloga.Uloga_id}, ime='{zaposlenik.Ime}', prezime='{zaposlenik.Prezime}', stručna_sprema='{zaposlenik.StrucnaSprema}', datum_zaposlenja='{datum}', broj_telefona='{zaposlenik.BrojTelefona}', adresa='{zaposlenik.Adresa}', email='{zaposlenik.Email}', lozinka='{zaposlenik.Lozinka}', korisničko_ime='{zaposlenik.KorisnickoIme}' WHERE oib={zaposlenik.OIB}";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        // metoda koja dohvaca sve uloge zaposlenika koje postoje u bazi
        public List<Uloga> DohvatiUlogeZaposlenika() {
            List<Uloga> listaUloga = new List<Uloga>();
            string sqlUpit = $"SELECT * FROM uloga";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Uloga uloga = DohvatiUlogu(dr);
                listaUloga.Add(uloga);
            }
            dr.Close();
            return listaUloga;
        }
        public List<Uloga> DohvatiUlogeZaposlenikaZaZaposlenike()
        {
            List<Uloga> listaUloga = new List<Uloga>();
            string sqlUpit = $"SELECT * FROM uloga WHERE uloga_id!=1 and uloga_id!=4";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Uloga uloga = DohvatiUlogu(dr);
                listaUloga.Add(uloga);
            }
            dr.Close();
            return listaUloga;
        }
        private Uloga DohvatiUlogu(SqlDataReader dr)
        {
            Uloga uloga = null;
            if (dr != null)
            {
               
                uloga = new Uloga();
                uloga.Uloga_id = int.Parse(dr["uloga_id"].ToString());
                uloga.Naziv = dr["naziv"].ToString();
          
            }
            return uloga;
        }

        //metoda koja brise zaposlenika
        public int ObrisiZaposlenika(Zaposlenik zaposlenik) {
            string sql = $"DELETE zaposlenik WHERE oib = {zaposlenik.OIB}";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        public int AzurirajKorisnickoIme(string oib, string korisnickoIme)
        {
            string sql = $"UPDATE zaposlenik SET korisničko_ime='{korisnickoIme}' WHERE oib='{oib}'";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }
        public int AzurirajLozinku(string oib, string lozinka)
        {
            string sql = $"UPDATE zaposlenik SET lozinka='{lozinka}' WHERE oib='{oib}'";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

    }

}
