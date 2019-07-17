using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobilis_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string failoVieta = @"C:\Users\Normanas\Desktop\masinos.csv";
            CsvNuskaitytojas skaitytojas = new CsvNuskaitytojas(failoVieta);

            List<Automobilis> masinos = skaitytojas.nuskaitykVisasMasinas();
            Automobilis Volvo = new Automobilis("Volvo S60", "VOV", "Svedija", 24000);
            int index = masinos.FindIndex(x => x.Kaina < 24000);
            masinos.Insert(index, Volvo);

            Console.WriteLine("Kiek masinu norite matyti?");
            bool ArIvestisSkaicius = int.TryParse(Console.ReadLine(), out int inputas);
            if (!ArIvestisSkaicius || inputas <= 0)
            {
                Console.WriteLine("Blogai ivedei");
                Console.ReadLine();
                return;
            }
            int maximalurodyti = inputas;


            for (int i = 0; i < masinos.Count; i++)
            {
                if (i > 0 && (i % maximalurodyti == 0))
                {
                    Console.WriteLine("pasusk enter, kad testi arba parasyk kanors, kad iseiti");
                    if (Console.ReadLine() != "")
                        break;
                    {

                    }

                }
                Automobilis masina = masinos[i];
                Console.WriteLine(i+1 + " " + masina.Pavadinimas);

                

            }
            Console.ReadLine();

            foreach (Automobilis masina in masinos.OrderBy(x=>x.Pavadinimas).Take(10))
            {
                Console.WriteLine(masina.Pavadinimas);
            }
            Console.WriteLine(masinos.Count);
            Console.ReadLine();




        }
    }

}
