using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class RutaRepozitorij
    {
        public List<Ruta> listaRuta = new List<Ruta>();

        public RutaRepozitorij()
        {

        }

        //Metoda vraća sve rute za ispis u datagridview
        public List<Ruta> DohvatiRute()
        {
            List<Ruta> lista = new List<Ruta>();
            string sql = null;
            if (PrijavaForma.uloga == 1)
            {
                sql = $"SELECT * FROM ruta left join zaposlenik on zaposlenik_oib=oib where zaposlenik.tvrtka_id={PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id};";
            }
            if (PrijavaForma.uloga == 2)
            {
                sql = $"SELECT * FROM ruta where kreirao='{PrijavaForma.oib}';";
            }
            if (PrijavaForma.uloga == 3)
            {
                sql = $"SELECT * FROM ruta where zaposlenik_oib='{PrijavaForma.oib}';";
            }
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Ruta ruta = new Ruta();
                ruta.Ruta_id = int.Parse(dr["ruta_id"].ToString());
                ruta.Zaposlenik_id = dr["zaposlenik_oib"].ToString();
                ruta.Kreirao = dr["kreirao"].ToString();
                ruta.Vozilo_registracija = dr["vozilo_registracija"].ToString();
                ruta.Broj_otpremnice = dr["broj_otpremnice"].ToString();
                ruta.Polazište = dr["polazište"].ToString();
                ruta.Odredište = dr["odredište"].ToString();
                ruta.Datum_i_vrijeme_polaska = dr["datum_i_vrijeme_polaska"].ToString();
                ruta.Očekivano_vrijeme_dolaska = dr["očekivano_vrijeme_dolaska"].ToString();
                if (dr["stvarno_vrijeme_dolaska"].ToString() != "")
                {
                    ruta.Stvarno_vrijeme_dolaska = dr["stvarno_vrijeme_dolaska"].ToString();
                }
                else ruta.Stvarno_vrijeme_dolaska = null;

                lista.Add(ruta);
            }
            dr.Close();
            return lista;
        }

        //Metoda vraća sve rute za ispis u cmbRute u DodajZapisnikForma
        //dohvaća rute za prijavljenog korisnika, dostavljene u nazad mjesec dana, za koje nije kreiran zapisnik
        public List<Ruta> DohvatiRuteZaZapisnik()
        {
            List<Ruta> lista = new List<Ruta>();
            string sql = null;
            if(PrijavaForma.uloga == 1)
            {
                sql = $"SELECT r.ruta_id as ruta_id, r.zaposlenik_oib as zaposlenik_oib, r.kreirao as kreirao, r.vozilo_registracija as vozilo_registracija, r.broj_otpremnice as broj_otpremnice, r.polazište as polazište, r.odredište as odredište, r.datum_i_vrijeme_polaska as datum_i_vrijeme_polaska, r.očekivano_vrijeme_dolaska as očekivano_vrijeme_dolaska, r.stvarno_vrijeme_dolaska as stvarno_vrijeme_dolaska FROM ruta r join zaposlenik z on r.kreirao = z.oib WHERE z.tvrtka_id = {PrijavaForma.prijavljeniZaposlenik.Tvrtka.Tvrtka_id};";
            }
            if (PrijavaForma.uloga == 2)
            {
                sql = $"SELECT * FROM ruta WHERE kreirao = {PrijavaForma.oib};";
            }
            if (PrijavaForma.uloga == 3)
            {
                sql = $"SELECT * FROM ruta WHERE (((stvarno_vrijeme_dolaska IS NULL OR (stvarno_vrijeme_dolaska > (GETDATE() - 30))) AND zaposlenik_oib = {PrijavaForma.oib}));";
            }
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Ruta ruta = new Ruta();
                ruta.Ruta_id = int.Parse(dr["ruta_id"].ToString());
                ruta.Zaposlenik_id = dr["zaposlenik_oib"].ToString();
                ruta.Kreirao = dr["kreirao"].ToString();
                ruta.Vozilo_registracija = dr["vozilo_registracija"].ToString();
                ruta.Broj_otpremnice = dr["broj_otpremnice"].ToString();
                ruta.Polazište = dr["polazište"].ToString();
                ruta.Odredište = dr["odredište"].ToString();
                ruta.Datum_i_vrijeme_polaska = dr["datum_i_vrijeme_polaska"].ToString();
                ruta.Očekivano_vrijeme_dolaska = dr["očekivano_vrijeme_dolaska"].ToString();
                if (dr["stvarno_vrijeme_dolaska"].ToString() != "")
                {
                    ruta.Stvarno_vrijeme_dolaska = dr["stvarno_vrijeme_dolaska"].ToString();
                }
                else ruta.Stvarno_vrijeme_dolaska = null;

                lista.Add(ruta);
            }
            dr.Close();
            return lista;
        }

        //Metoda koja prima rutu od IspisRuteUC i dodaje ju u bazu
        public int DodajRutu(Ruta ruta)
        {
            if (ruta != null && DateTime.Parse(ruta.Očekivano_vrijeme_dolaska) > DateTime.Parse(ruta.Datum_i_vrijeme_polaska))
            {
                string sql = $"INSERT INTO ruta (zaposlenik_oib, kreirao, vozilo_registracija, broj_otpremnice, polazište, " +
                    $"odredište, datum_i_vrijeme_polaska, očekivano_vrijeme_dolaska) VALUES ('{ruta.Zaposlenik_id}'," +
                    $" '{ruta.Kreirao}', '{ruta.Vozilo_registracija}', '{ruta.Broj_otpremnice}', '{ruta.Polazište}', '{ruta.Odredište}', '{DateTime.Parse(ruta.Datum_i_vrijeme_polaska).ToString("yyyy-MM-dd hh:mm:ss")}', " +
                    $" '{DateTime.Parse(ruta.Očekivano_vrijeme_dolaska).ToString("yyyy-MM-dd HH:mm:ss")}');";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
            else 
            {
                return 0;
            }
        }

        //Metoda koja prima staru i ažuriranu rutu od IspisRuterUC i staru rutu ažurira u novu
        public int AžurirajRutu(Ruta ruta)
        {
            if (ruta != null && DateTime.Parse(ruta.Očekivano_vrijeme_dolaska) > DateTime.Parse(ruta.Datum_i_vrijeme_polaska))
            {
                string sql = $"UPDATE ruta SET zaposlenik_oib = '{ruta.Zaposlenik_id}', kreirao = '{ruta.Kreirao}', vozilo_registracija = '{ruta.Vozilo_registracija}', " +
                    $" broj_otpremnice = '{ruta.Broj_otpremnice}', polazište='{ruta.Polazište}', odredište='{ruta.Odredište}', datum_i_vrijeme_polaska='{DateTime.Parse(ruta.Datum_i_vrijeme_polaska).ToString("yyyy-MM-dd hh:mm:ss")}', " +
                    $" očekivano_vrijeme_dolaska='{DateTime.Parse(ruta.Očekivano_vrijeme_dolaska).ToString("yyyy-MM-dd hh:mm:ss")}'  WHERE ruta_id = {ruta.Ruta_id};";
                int i = Database.Instance.IzvrsiUpit(sql);
                return i;
            }
            else return 0; 
        }

        public int PotvrdiDolazak(Ruta ruta)
        {
            string sql = $"UPDATE ruta set stvarno_vrijeme_dolaska=GETDATE() WHERE ruta_id = {ruta.Ruta_id};";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        //Metoda koja briše rutu
        public int ObrišiRutu(Ruta ruta)
        {
            string sqlDelete = "DELETE FROM ruta WHERE ruta_id = " + ruta.Ruta_id;
            return Database.Instance.IzvrsiUpit(sqlDelete);

        }

        //Dohvaća sve rute za pojedinog zaposlenika
        public List<Ruta> DohvatiRute(Zaposlenik zaposlenik)
        {
            return null;
        }

    }
}
