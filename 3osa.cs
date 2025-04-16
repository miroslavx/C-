using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorrutustabelApp
{
    internal class Program
    {
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            
            for (int rida = 0; rida < ridadeArv; rida++)
            {
                for (int veerg = 0; veerg < veergudeArv; veerg++)
                {
                    tabel[rida, veerg] = (rida + 1) * (veerg + 1);
                }
            }
            
            int laius = (ridadeArv * veergudeArv).ToString().Length + 1;
            
            Console.Write("".PadLeft(laius));
            for (int veerg = 0; veerg < veergudeArv; veerg++)
            {
                Console.Write(String.Format("{0," + laius + "}", veerg + 1));
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', (veergudeArv + 1) * laius));
            
            for (int rida = 0; rida < ridadeArv; rida++)
            {
                Console.Write(String.Format("{0," + laius + "}", rida + 1));
                
                for (int veerg = 0; veerg < veergudeArv; veerg++)
                {
                    Console.Write(String.Format("{0," + laius + "}", tabel[rida, veerg]));
                }
                Console.WriteLine();
            }
            
            return tabel;
        }
        
        public static void OtsiVäärtus(int[,] tabel, int arv1, int arv2)
        {
            if (arv1 <= tabel.GetLength(0) && arv2 <= tabel.GetLength(1) && arv1 > 0 && arv2 > 0)
            {
                int tulemus = tabel[arv1 - 1, arv2 - 1];
                Console.WriteLine($"{arv1} x {arv2} = {tulemus}");
            }
            else
            {
                Console.WriteLine("Viga: Need arvud on väljaspool tabeli piire!");
            }
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Korrutustabeli programm");
            Console.WriteLine("=======================");
            
            Console.Write("Sisesta ridade arv: ");
            if (!int.TryParse(Console.ReadLine(), out int ridadeArv) || ridadeArv <= 0)
            {
                Console.WriteLine("Vigane sisend! Kasutan vaikeväärtust 10.");
                ridadeArv = 10;
            }
            
            Console.Write("Sisesta veergude arv: ");
            if (!int.TryParse(Console.ReadLine(), out int veergudeArv) || veergudeArv <= 0)
            {
                Console.WriteLine("Vigane sisend! Kasutan vaikeväärtust 10.");
                veergudeArv = 10;
            }
            
            Console.WriteLine();
            Console.WriteLine("Korrutustabel:");
            int[,] tabel = GenereeriKorrutustabel(ridadeArv, veergudeArv);
            
            Console.WriteLine();
            Console.WriteLine("Soovid otsida väärtust tabelist? (jah/ei)");
            string vastus = Console.ReadLine().ToLower();
            
            while (vastus == "jah")
            {
                Console.Write("Sisesta esimene arv: ");
                if (!int.TryParse(Console.ReadLine(), out int arv1))
                {
                    Console.WriteLine("Vigane sisend!");
                    continue;
                }
                
                Console.Write("Sisesta teine arv: ");
                if (!int.TryParse(Console.ReadLine(), out int arv2))
                {
                    Console.WriteLine("Vigane sisend!");
                    continue;
                }
                
                OtsiVäärtus(tabel, arv1, arv2);
                
                Console.WriteLine("\nSoovid veel otsida? (jah/ei)");
                vastus = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine("\nProgramm lõpetatud. Vajuta suvalist klahvi väljumiseks...");
            Console.ReadKey();
        }
    }
}
