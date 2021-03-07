using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class VoziloRepozitorij
    {   
        public VoziloRepozitorij()
        {

        }

        //Metoda vraća sva vozila za ispis u datagridview
        public List<Vozilo> DohvatiVozila()
        {
            List<Vozilo> lista = new List<Vozilo>();
            string sql = $"SELECT * FROM vozilo WHERE tvrtka_id = {PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id};";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Vozilo vozilo = new Vozilo();
                vozilo.Registracija = dr["registracija"].ToString();
                vozilo.Vrsta_vozila = int.Parse(dr["vrsta_vozila_id"].ToString());
                vozilo.Marka = dr["marka"].ToString();
                vozilo.Godina_proizvodnje = int.Parse(dr["godina_proizvodnje"].ToString());
                vozilo.Nosivost = dr["nosivost"].ToString();

                lista.Add(vozilo);
            }
            dr.Close();
            return lista;
        }

        public Vozilo DohvatiVozilo(SqlDataReader dr)
        {
            Vozilo vozilo = new Vozilo();
            if(dr!=null)
            {
                vozilo.Registracija = dr["registracija"].ToString();
                vozilo.Vrsta_vozila = int.Parse(dr["vrsta_vozila_id"].ToString());
                vozilo.Marka = dr["marka"].ToString();
                vozilo.Godina_proizvodnje = int.Parse(dr["godina_proizvodnje"].ToString());
                vozilo.Nosivost = dr["nosivost"].ToString();
            }
            return vozilo;
        }

        //Metoda vraća sva slobodna vozila unutar željenog intervala prilikom kreiranja ruta
        public List<Vozilo> DohvatiVoziloRuta()
        {
            List<Vozilo> listaVozila = new List<Vozilo>();
            string sqlUpit = $"SELECT * from vozilo v where not exists ( select 1 from ruta r where '{DodajRutuForma.vrijemePolaska.ToString("yyyy-MM-dd HH:mm:ss")}' < r.očekivano_vrijeme_dolaska and '{DodajRutuForma.vrijemeDolaska.ToString("yyyy-MM-dd HH:mm:ss")}' > r.datum_i_vrijeme_polaska and registracija=vozilo_registracija) and tvrtka_id={PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id}";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Vozilo vozilo = DohvatiVozilo(dr);
                listaVozila.Add(vozilo);
            }
            dr.Close();
            return listaVozila;
        }

        //Metoda koja prima vozilo od IspisVozilaUC i dodaje ga u bazu
        public int DodajVozilo(Vozilo vozilo)
        {
            if (vozilo.Registracija == "" || vozilo.Marka == "" || vozilo.Vrsta_vozila.ToString() == "" || vozilo.Nosivost == "")
            {
                throw new System.FormatException();
            }
            else
            {
                string sql = $"INSERT INTO vozilo (registracija, vrsta_vozila_id, marka, godina_proizvodnje, nosivost, tvrtka_id) VALUES ('{vozilo.Registracija}', {vozilo.Vrsta_vozila}, '{vozilo.Marka}', {vozilo.Godina_proizvodnje}, '{vozilo.Nosivost}', {PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id});";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
        }

        //Metoda koja prima staro i ažurirano vozilo od IspisVozilaUC i staro vozilo ažurira u novo
        public int AzurirajVozilo(Vozilo vozilo)
        {
            if (vozilo.Registracija == "" || vozilo.Marka == "" || vozilo.Vrsta_vozila.ToString() == "" || vozilo.Nosivost == "")
            {
                throw new System.FormatException();
            }
            else
            {
                string sql = $"UPDATE vozilo SET vrsta_vozila_id = {vozilo.Vrsta_vozila}, marka = '{vozilo.Marka}', godina_proizvodnje = {vozilo.Godina_proizvodnje}, nosivost = '{vozilo.Nosivost}' WHERE registracija = '{vozilo.Registracija}';";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
        }

        //Metoda briše zapisnik
        public int ObrisiVozilo(Vozilo vozilo)
        {
            string sql = $"DELETE vozilo WHERE registracija = '{vozilo.Registracija}';";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Dohvaća sve vrste vozila koje se upisuju u combobox u formi za dodavanje vozila
        public List<VrstaVozila> DohvatiVrsteVozila()
        {
            List<VrstaVozila> lista = new List<VrstaVozila>();
            string sql = $"SELECT * FROM vrsta_vozila ORDER BY 1;";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                VrstaVozila vrstaVozila = new VrstaVozila();
                vrstaVozila.vrsta_id = int.Parse(dr["vrsta_id"].ToString());
                vrstaVozila.naziv = dr["naziv"].ToString();

                lista.Add(vrstaVozila);
            }
            dr.Close();
            return lista;
        }

    }
}
