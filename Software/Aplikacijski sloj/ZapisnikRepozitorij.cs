using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class ZapisnikRepozitorij
    {
        int zadnjiZapisnik;
        
        public ZapisnikRepozitorij()
        {

        }

        //Metoda vraća sve zapisnike za ispis u datagridview
        public List<Zapisnik> DohvatiZapisnike()
        {
            List<Zapisnik> lista = new List<Zapisnik>();
            string sql = null;
            if (PrijavaForma.uloga == 1) { 
                sql = $"SELECT z.zapisnik_id as zapisnik_id, z.ruta_id as ruta_id, z.opis as opis, z.datum_i_vrijeme as datum_i_vrijeme, z.obrađen as obrađen FROM zapisnik z join ruta r on z.ruta_id = r.ruta_id join zaposlenik za on r.kreirao = za.oib WHERE za.tvrtka_id = {PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id};";
            }
            if (PrijavaForma.uloga == 2)
            {
                sql = $"SELECT z.zapisnik_id as zapisnik_id, z.ruta_id as ruta_id, z.opis as opis, z.datum_i_vrijeme as datum_i_vrijeme, z.obrađen as obrađen FROM zapisnik z join ruta r on z.ruta_id = r.ruta_id WHERE r.kreirao = {PrijavaForma.oib};";
            }
            if (PrijavaForma.uloga == 3)
            {
                sql = $"SELECT z.zapisnik_id as zapisnik_id, z.ruta_id as ruta_id, z.opis as opis, z.datum_i_vrijeme as datum_i_vrijeme, z.obrađen as obrađen FROM zapisnik z join ruta r on z.ruta_id = r.ruta_id WHERE r.zaposlenik_oib = {PrijavaForma.oib};";
            }
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Zapisnik zapisnik = new Zapisnik();
                zapisnik.Zapisnik_id = int.Parse(dr["zapisnik_id"].ToString());
                zadnjiZapisnik = int.Parse(dr["zapisnik_id"].ToString());
                zapisnik.Ruta_id = int.Parse(dr["ruta_id"].ToString());
                zapisnik.Opis = dr["opis"].ToString();
                zapisnik.Datum_i_vrijeme = DateTime.Parse(dr["datum_i_vrijeme"].ToString());
                if(dr["obrađen"].ToString() == "1")
                {
                    zapisnik.Obrađen = "Da";
                }
                if (dr["obrađen"].ToString() == "0")
                {
                    zapisnik.Obrađen = "Ne";
                }

                lista.Add(zapisnik);
            }
            dr.Close();
            return lista;
        }

        //Metoda koja prima zapisnik od IspisZapisnikaUC i dodaje ga u bazu
        public int DodajZapisnik(Zapisnik zapisnik)
        {
            string sql = $"INSERT INTO zapisnik (ruta_id, opis, datum_i_vrijeme, obrađen) VALUES ({zapisnik.Ruta_id}, '{zapisnik.Opis}', GETDATE(), 0);";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Metoda koja prima zapisnik od IspisZapisnikaUC i dodaje vrijednosti u tablicu zapisnik_greške
        public int DodajZapisnikGreske(Zapisnik zapisnik)
        {
            DohvatiZapisnike();
            int i = 0;
            foreach (var item in zapisnik.ListaGreski)
            {
                string sql = $"INSERT INTO zapisnik_greške (zapisnik_id, greška_id) VALUES ({zadnjiZapisnik}, {item.greska_id});";
                i = Database.Instance.IzvrsiUpit(sql);
            }
            return i;
        }


        //Metoda koja prima stari i ažurirani zapisnik od IspisZapisnikaUC i stari zapisnik ažurira u novi
        public int AzurirajZapisnik(Zapisnik zapisnik)
        {
            string sql = $"UPDATE zapisnik SET ruta_id = {zapisnik.Ruta_id}, opis = '{zapisnik.Opis}', datum_i_vrijeme = GETDATE(), obrađen = 0 WHERE zapisnik_id = {zapisnik.Zapisnik_id};";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Metoda koja prima zapisnik od IspisZapisnikaUC i dodaje vrijednosti u tablicu zapisnik_greške
        public int AzurirajZapisnikGreske(Zapisnik zapisnik)
        {
            int i = 0;
            foreach (var item in zapisnik.ListaGreski)
            {
                string sql = $"INSERT INTO zapisnik_greške (zapisnik_id, greška_id) VALUES ({zapisnik.Zapisnik_id}, {item.greska_id});";
                i = Database.Instance.IzvrsiUpit(sql);
            }
            return i;
        }

        //Metoda briše zapisnik
        public int ObrisiZapisnik(Zapisnik zapisnik)
        {
            string sql = $"DELETE zapisnik WHERE zapisnik_id = {zapisnik.Zapisnik_id};";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Metoda briše zapise iz tablice zapisnik_greške jer se prilikom ažuriranja zapisnika mogu promijeniti
        //greške za taj zapisnik, ukoliko se ne obriše i ponovo upiše ostali bi pogrešni podaci
        public int ObrisiZapisnikGreske(Zapisnik zapisnik)
        {
            string sql = $"DELETE zapisnik_greške WHERE zapisnik_id = {zapisnik.Zapisnik_id};";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Dohvaća greške iz baze koje prosljeđuje prema DodajZapisnikForma gdje se greške učitavaju kako bi ih vozač mogao odabrati
        public List<Greska> DohvatiGreske()
        {
            List<Greska> lista = new List<Greska>();
            string sql = $"SELECT * FROM greške;";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Greska greska = new Greska();
                greska.greska_id = int.Parse(dr["greška_id"].ToString());
                greska.naziv = dr["naziv"].ToString();
                greska.opis = dr["opis"].ToString();

                lista.Add(greska);
            }
            dr.Close();
            return lista;
        }

        //Dohvaća greške za odabrani zapisnik u dgvZapisnici i na temelju ID-a odabranog zapisnika u 
        //dgvGreske ispisuje greške tog zapisnika
        public List<Greska> DohvatiGreskeZapisnika(int zapisnikID)
        {
            List<Greska> lista = new List<Greska>();
            string sql = $"SELECT * FROM greške g join zapisnik_greške zg on g.greška_id = zg.greška_id join zapisnik z on zg.zapisnik_id = z.zapisnik_id WHERE z.zapisnik_id = {zapisnikID};";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Greska greska = new Greska();
                greska.greska_id = int.Parse(dr["greška_id"].ToString());
                greska.naziv = dr["naziv"].ToString();
                greska.opis = dr["opis"].ToString();

                lista.Add(greska);
            }
            dr.Close();
            return lista;
        }

        //Metoda vraća objekt tipa Greška kojeg pohranjuje u listu greški za određeni zapisnik, metoda koristi parametar naziv greške koja
        //je označena u checked list boxu na formi za dodavanje i ažuriranje zapisnika
        public Greska DohvatiGreskuPremaNazivu(string naziv)
        {
            Greska greska = null;
            string sql = $"SELECT * FROM greške WHERE naziv = '{naziv}';";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                greska = new Greska();
                greska.greska_id = int.Parse(dr["greška_id"].ToString());
                greska.naziv = dr["naziv"].ToString();
                greska.opis = dr["opis"].ToString();
            }
            dr.Close();
            return greska;
        }

        //Klikon na gumb Obrađen/neobrađen u user controli za ispis zapisnika disponent označuje zapisnik kao obrađen ili neobrađen
        //i ova metoda ažurira stanje zapisnika u bazi podataka
        public int PromijeniStatusZapisnika(Zapisnik zapisnik)
        {
            if(zapisnik.Obrađen == "Ne")
            {
                string sql = $"UPDATE zapisnik SET obrađen = 1 WHERE zapisnik_id = {zapisnik.Zapisnik_id};";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
            else
            {
                string sql = $"UPDATE zapisnik SET obrađen = 0 WHERE zapisnik_id = {zapisnik.Zapisnik_id};";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
        }

    }
}
