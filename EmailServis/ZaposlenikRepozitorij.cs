using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailServis
{
    class ZaposlenikRepozitorij
    {
        //Dohvaća sve zaposlenike koji imaju rute čije je očekivano vrijeme dolaska bilo prije 3 ili više dana, te za te rute nije
        //ni potvrđeno vrijeme dolaska ni kreiran zapisnik
        public List<Zaposlenik> DohvatiZaposlenikeZaEmail()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();
            string sql = $"SELECT DISTINCT z.oib as oib, z.uloga_id as uloga_id, z.ime as ime, z.prezime as prezime, z.stručna_sprema as stručna_sprema, z.datum_zaposlenja as datum_zaposlenja, z.broj_telefona as broj_telefona, z.adresa as adresa, z.email as email, z.lozinka as lozinka, z.korisničko_ime as korisničko_ime FROM zaposlenik z join ruta r on z.oib = r.zaposlenik_oib WHERE stvarno_vrijeme_dolaska IS NULL AND očekivano_vrijeme_dolaska <= (GETDATE() - 2);";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Zaposlenik zaposlenik = new Zaposlenik();
                zaposlenik.OIB = dr["oib"].ToString();
                zaposlenik.Ime = dr["ime"].ToString();
                zaposlenik.Prezime = dr["prezime"].ToString();
                zaposlenik.StrucnaSprema = dr["stručna_sprema"].ToString();
                zaposlenik.DatumZaposlenja = DateTime.Parse(dr["datum_zaposlenja"].ToString());
                zaposlenik.BrojTelefona = dr["broj_telefona"].ToString();
                zaposlenik.Adresa = dr["adresa"].ToString();
                zaposlenik.Email = dr["email"].ToString();
                zaposlenik.Lozinka = dr["lozinka"].ToString();
                zaposlenik.Uloga = null;
                zaposlenik.KorisnickoIme = dr["korisničko_ime"].ToString();

                lista.Add(zaposlenik);
            }
            dr.Close();
            return lista;
        }
    }
}
