using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Automobilis
{
    class CsvNuskaitytojas
    {
        private string _csvFailoKelias;

        public CsvNuskaitytojas(string csvFailoKelias)
        {
            this._csvFailoKelias = csvFailoKelias;
        }

        public Automobilis[] nuskaitykMasinas(int nMasinu)
        {
            Automobilis[] masinos = new Automobilis[nMasinu];

            using (StreamReader sr = new StreamReader(_csvFailoKelias))
            {
                sr.ReadLine();

                for (int i = 0; i < nMasinu; i++)
                {
                    string csvLine = sr.ReadLine();
                    masinos[i] = NuskaitykMasinasIsFailoCsv(csvLine);
                }
            }


            return masinos;
               

        }

        public Automobilis NuskaitykMasinasIsFailoCsv (string CsvEilute)
        {
            string[] dalys = CsvEilute.Split(new char[] { ',' });

            string pavadinimas = dalys[0];
            string kodas = dalys[1];
            string salis = dalys[2];
            int kaina = int.Parse(dalys[3]);

            return new Automobilis(pavadinimas, kodas, salis, kaina);

        }
    }
}
