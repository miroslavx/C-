using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere! Hea Päev! Привет!");
            // I.osa Andmetüübd, If, Case, Random, Alamfunktsioonid
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4536237287;
            float arv1 = 2;
            int arv2 = 10; // Added variable declaration for arv2

            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("Tere!\n {0}", tekst);

            // Check if name is "juku"
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lahme kinno!");
                try
                {
                    Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) //&& - and, || - or
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        Console.WriteLine("Tasuta pilet!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // Calling the Calculator function with correct name
            arv1 = FunktsioonideClass.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine(a);
            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                case 7: tekst = "P"; break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }

    // Function class with the calculator method
    internal class FunktsioonideClass
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = arv1 + arv2;
            return kalkulaator;
        }
    }
}