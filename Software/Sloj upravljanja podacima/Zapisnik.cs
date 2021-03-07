using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Zapisnik
    {
        public int Zapisnik_id { get; set; }
        public int Ruta_id { get; set; }
        public string Opis { get; set; }
        public DateTime Datum_i_vrijeme { get; set; }
        public List<Greska> ListaGreski { get; set; }
        public string Obrađen { get; set; }

        public Zapisnik()
        {

        }

        public Zapisnik(int zapisnik_id, int ruta_id, string opis, DateTime datum_i_vrijeme, List<Greska> listaGreski)
        {
            Zapisnik_id = zapisnik_id;
            Ruta_id = ruta_id;
            Opis = opis;
            Datum_i_vrijeme = datum_i_vrijeme;
            ListaGreski = new List<Greska>();
            ListaGreski = listaGreski;
        }
           
    }
}
