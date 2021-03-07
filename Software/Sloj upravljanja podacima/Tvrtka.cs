using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp.Sloj_upravljanja_podacima
{
    public class Tvrtka
    {
        [DisplayName("ID")]
        public int Tvrtka_id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
