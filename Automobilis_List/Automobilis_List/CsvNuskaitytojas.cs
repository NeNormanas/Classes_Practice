using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Automobilis_List
{
    class CsvNuskaitytojas
    {
        private string _csvFailoKelias;

        public CsvNuskaitytojas(string csvFailoKelias)
        {
            this._csvFailoKelias = csvFailoKelias;
        }

        public  List<Automobilis> nuskaitykVisasMasinas()
        {
            List<Automobilis> masinos = new List<Automobilis>();
            Automobilis Volvo = new Automobilis("Volvo S60", "VOV", "Svedija", 24000);

            using (StreamReader sr = new StreamReader(_csvFailoKelias))
            {
                //sr.ReadLine();

                string csvLine = sr.ReadLine();
                while ((csvLine = sr.ReadLine()) != null)
                {
                    masinos.Add(NuskaitykMasinasIsFailoCsv(csvLine));
                }
            
                    
            }


            return masinos;


        }

        public Automobilis NuskaitykMasinasIsFailoCsv(string CsvEilute)
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
