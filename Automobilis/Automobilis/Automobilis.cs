using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilis
{
    class Automobilis
    {
        public string Pavadinimas { get; }
        public string Kodas { get; }
        public string Salis { get; }
        public int Kaina { get; }

        public Automobilis(string pavadinimas, string kodas, string salis, int kaina)
        {
            this.Pavadinimas = pavadinimas;
            this.Kodas = kodas;
            this.Salis = salis;
            this.Kaina = kaina;
        }

            
    }
}
