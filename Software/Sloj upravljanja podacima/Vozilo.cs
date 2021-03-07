using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Sloj_upravljanja_podacima;

namespace TransportApp
{
    public class Vozilo
    {
        public string Registracija { get; set; }
        public int Vrsta_vozila { get; set; }
        public string Marka { get; set; }
        public int Godina_proizvodnje { get; set; }
        public string Nosivost { get; set; }
        public Tvrtka Tvrtka { get; set; }

        public Vozilo()
        {

        }

        public Vozilo(string registracija, int vrsta_vozila, string marka, int godina_proizvodnje, string nosivost, Tvrtka tvrtka)
        {
            Registracija = registracija;
            Vrsta_vozila = vrsta_vozila;
            Marka = marka;
            Godina_proizvodnje = godina_proizvodnje;
            Nosivost = nosivost;
            Tvrtka = tvrtka;
        }

        public override string ToString()
        {
            return Registracija;
        }
    }
}
