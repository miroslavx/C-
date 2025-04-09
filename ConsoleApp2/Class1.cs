using System;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            // Tervitus
            Console.WriteLine("Tere tulemast!");

            // Nime küsimine
            Console.Write("Sisesta oma nimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            // Arvude küsimine
            Console.Write("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());

            // Arvutamine ja tulemuse kuvamine
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);

            // Ootab kasutaja sisendit enne programmi lõpetamist
            Console.WriteLine("Vajuta Enter klahvi programmi lõpetamiseks...");
            Console.ReadLine();
        }
    }
}