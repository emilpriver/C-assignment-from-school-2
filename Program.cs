using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamensadministration
{
    class Program
    {
        static Kurs[] kurser = Randomizer.GenerateKurser(20);
        static Student[] studenter = Randomizer.GenerateStudenter(20);
        static Tentamen[] tentamina = Randomizer.GenerateTentamina(20, studenter, kurser);
        
        static void Main(string[] args)
        {
            for (int i = 0; i < tentamina.Length; i++)
            {
                Tentamen t = tentamina[i];

                Console.WriteLine(
                    t.studenten + "\t" + t.kursen + "\t" +
                    t.datum + "\t" + t.poäng + "\t" + t.betyg);
            }

            Console.ReadLine();


        }
    }
}
