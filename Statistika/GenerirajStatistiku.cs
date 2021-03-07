using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika
{
    public class GenerirajStatistiku
    {
        public int DohvatiBrojOdvoženihRuta(int uloga, string oib, int tvrtka)
        {
            if (uloga == 1)
            {
                string sql = $"select count(*) from ruta left join zaposlenik on zaposlenik.tvrtka_id={tvrtka} where stvarno_vrijeme_dolaska !='' and oib=zaposlenik_oib ";
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            if (uloga == 2)
            {
                string sql = $"select count(*) from ruta where kreirao='{oib}' and stvarno_vrijeme_dolaska !='' ";
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            if (uloga == 3)
            {
                string sql = $"select count(*) from ruta where zaposlenik_oib='{oib}' and stvarno_vrijeme_dolaska !='' ";
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            return 0;
        }

        public int DohvatiAdminRute(string oib)
        {
            string sql = $"select count(*) from ruta where kreirao='{oib}' and stvarno_vrijeme_dolaska !='' ";
            return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
        }

        public int DohvatiBrojNeodvoženihRuta(int uloga, string oib, int tvrtka)
        {
            if (uloga == 1)
            {
                string sql = $"select count(*) from ruta left join zaposlenik on zaposlenik.tvrtka_id={tvrtka} where stvarno_vrijeme_dolaska is null and oib=zaposlenik_oib "; 
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            if (uloga == 2)
            {
                string sql = $"select count(*) from ruta where kreirao='{oib}' and stvarno_vrijeme_dolaska is null ";
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            if (uloga == 3)
            {
                string sql = $"select count(*) from ruta where zaposlenik_oib='{oib}' and stvarno_vrijeme_dolaska is null ";
                return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
            }
            return 0;
        }

        public double DOhvatiUkupnoVrijeme(int uloga, string oib, int tvrtka)
        {
            if (uloga == 1)
            {
                string sql = $"select sum(datediff(day, datum_i_vrijeme_polaska, očekivano_vrijeme_dolaska)) from ruta left join zaposlenik on zaposlenik_oib=oib where tvrtka_id={tvrtka} and stvarno_vrijeme_dolaska is not null ";
                try
                {
                    return Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql));
                }
                catch
                {
                    return 0;
                }
            }
            if (uloga == 2)
            {
                string sql = $"select sum(datediff(day, datum_i_vrijeme_polaska, očekivano_vrijeme_dolaska)) from ruta where kreirao='{oib}' and stvarno_vrijeme_dolaska is not null ";
                try
                {
                    return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
                }
                catch
                {
                    return 0;
                }
            }
            if (uloga == 3)
            {
                string sql = $"select sum(datediff(day, datum_i_vrijeme_polaska, očekivano_vrijeme_dolaska)) from ruta where zaposlenik_oib='{oib}' and stvarno_vrijeme_dolaska is not null";
                try
                {
                    return Convert.ToInt32(Database2.Instance.DohvatiVrijednost(sql));
                }
                catch
                {
                    return 0;
                }
            }
            return 0;
        }

        public double DOhvatiProsjekRuta(int uloga, int tvrtka)
        {
            string sql = $"select count(*) from ruta left join zaposlenik on zaposlenik.tvrtka_id={tvrtka} where zaposlenik_oib=oib";
            if (uloga == 3)
            {
                string sql2 = $"select count(*) from zaposlenik where uloga_id=3 and tvrtka_id={tvrtka}";
                double brojruta = Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql));
                double brojvozača = Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql2));
                return brojruta / brojvozača;
            }
            if (uloga == 2 || uloga == 1)
            {
                string sql2 = $"select count(*) from zaposlenik where (uloga_id=2 or uloga_id=1) and tvrtka_id={tvrtka}";
                double brojruta = Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql));
                double brojdisponenata = Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql2));
                return brojruta / brojdisponenata;
            }
            return 0;
        }

        public double DohvatiProsjekStaž(int tvrtka)
        {
            string sql = $"select AVG(datediff(month, datum_zaposlenja, GETDATE())) from zaposlenik where tvrtka_id={tvrtka}";
            return Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql));
        }

        public double DohvatiStaž(string oib)
        {
            string sql = $"select datediff(month, datum_zaposlenja, GETDATE()) from zaposlenik where oib='{oib}'";
            return Convert.ToDouble(Database2.Instance.DohvatiVrijednost(sql));
        }

    }
}
