using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilis
{
    class Program
    {
        static void Main(string[] args)
        {
            string failoVieta = @"C:\Users\Normanas\Desktop\masinos.csv";
            CsvNuskaitytojas skaitytojas = new CsvNuskaitytojas(failoVieta);

            Automobilis[] masinos = skaitytojas.nuskaitykMasinas(5);

            foreach (Automobilis masina in masinos)
            {
                Console.WriteLine(masina.Salis);
            }
            Console.ReadLine();


        }
    }
}
