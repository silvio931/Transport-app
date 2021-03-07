using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp.Aplikacijski_sloj
{
    public class TvrtkaRepozitorij
    {
        public Tvrtka DohvatiTvrtku(SqlDataReader dr)
        {
            Tvrtka tvrtka = null;
            if (dr != null)
            {
                tvrtka = new Tvrtka();
                tvrtka.Tvrtka_id = int.Parse(dr["tvrtka_id"].ToString());
                tvrtka.Naziv = dr["naziv"].ToString();
                tvrtka.Adresa = dr["adresa"].ToString();
            }
            return tvrtka;
        }
        public List<Tvrtka> DohvatiTvrtke()
        {
            List<Tvrtka> listaTvrtki = new List<Tvrtka>();
            string sqlUpit = $"SELECT * FROM tvrtka";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Tvrtka tvrtka = DohvatiTvrtku(dr);
                listaTvrtki.Add(tvrtka);
            }
            dr.Close();
            return listaTvrtki;
        }
        public int DodajTvrtku(Tvrtka tvrtka)
        {
            string sql = $"INSERT INTO tvrtka(naziv, adresa) VALUES ('{tvrtka.Naziv}', '{tvrtka.Adresa}')";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }

        public int AzurirajTvrtku(Tvrtka tvrtka)
        {
            string sql = $"UPDATE tvrtka SET naziv='{tvrtka.Naziv}', adresa='{tvrtka.Adresa}' WHERE tvrtka_id={tvrtka.Tvrtka_id}";
            int i = Database.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
