using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class VrstaVozila
    {
        public int vrsta_id { get; set; }
        public string naziv { get; set; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
