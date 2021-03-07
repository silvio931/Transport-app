using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Greska
    {
        public int greska_id { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }

        public override string ToString()
        {
            return naziv;
        }
    }

}
