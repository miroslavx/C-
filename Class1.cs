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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere! Hea Päev! Привет!");

            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4536237287;
            float arv1 = 2;
            int arv2 = 10;

            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n" + tekst);
            Console.WriteLine("Tere!\n {0}", tekst);

            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lahme kinno!");
                try
                {
                    Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100)
                    {
                        Console.WriteLine("Viga andmetega!");
                    }
                    else if (vanus > 0 && vanus < 6)
                    {
                        Console.WriteLine("Tasuta pilet!");
                    }
                    else if (vanus >= 6 && vanus <= 14)
                    {
                        Console.WriteLine("Lastepilet!");
                    }
                    else if (vanus >= 15 && vanus <= 65)
                    {
                        Console.WriteLine("Täispilet!");
                    }
                    else if (vanus > 65 && vanus <= 100)
                    {
                        Console.WriteLine("Sooduspilet!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            Console.WriteLine("\nPinganaabrid ülesanne:");
            Console.Write("Sisesta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();
            Console.Write("Sisesta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();
            Console.WriteLine("{0} ja {1} on täna pinginaabrid!", nimi1, nimi2);

            Console.WriteLine("\nRuumi remondi ülesanne:");
            Console.Write("Sisesta ruumi pikkus (m): ");
            float pikkus = float.Parse(Console.ReadLine());
            Console.Write("Sisesta ruumi laius (m): ");
            float laius = float.Parse(Console.ReadLine());
            float pindala = pikkus * laius;
            Console.WriteLine("Ruumi pindala on {0} ruutmeetrit", pindala);

            Console.Write("Kas soovid teha remonti? (jah/ei): ");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                Console.Write("Kui palju maksab ruutmeeter (euro): ");
                float hind = float.Parse(Console.ReadLine());
                float koguhind = pindala * hind;
                Console.WriteLine("Põranda vahetamise hind on {0} eurot", koguhind);
            }
            Console.WriteLine("\nHinnasoodustuse ülesanne:");
            Console.Write("Sisesta 30% soodustusega hind: ");
            float soodushind = float.Parse(Console.ReadLine());
            float alghind = soodushind / 0.7f;
            Console.WriteLine("Alghind on {0}", alghind);
            Console.WriteLine("\nTemperatuuri kontroll:");
            Console.Write("Sisesta temperatuur: ");
            float temp = float.Parse(Console.ReadLine());
            if (temp > 18)
            {
                Console.WriteLine("Temperatuur on üle 18 kraadi. Soovitav toasoojus talvel!");
            }
            else
            {
                Console.WriteLine("Temperatuur on 18 kraadi või vähem.");
            }
            Console.WriteLine("\nPikkuse kategoriseerimine:");
            Console.Write("Sisesta inimese pikkus (cm): ");
            int pikkusCm = int.Parse(Console.ReadLine());
            if (pikkusCm < 160)
            {
                Console.WriteLine("Lühike");
            }
            else if (pikkusCm >= 160 && pikkusCm < 180)
            {
                Console.WriteLine("Keskmine");
            }
            else
            {
                Console.WriteLine("Pikk");
            }
            Console.WriteLine("\nPikkuse kategoriseerimine soo järgi:");
            Console.Write("Sisesta inimese pikkus (cm): ");
            pikkusCm = int.Parse(Console.ReadLine());
            Console.Write("Sisesta sugu (M/N): ");
            string sugu = Console.ReadLine();

            if (sugu.ToUpper() == "M")
            {
                if (pikkusCm < 170)
                {
                    Console.WriteLine("Lühike mees");
                }
                else if (pikkusCm >= 170 && pikkusCm < 185)
                {
                    Console.WriteLine("Keskmise pikkusega mees");
                }
                else
                {
                    Console.WriteLine("Pikk mees");
                }
            }
            else if (sugu.ToUpper() == "N")
            {
                if (pikkusCm < 160)
                {
                    Console.WriteLine("Lühike naine");
                }
                else if (pikkusCm >= 160 && pikkusCm < 175)
                {
                    Console.WriteLine("Keskmise pikkusega naine");
                }
                else
                {
                    Console.WriteLine("Pikk naine");
                }
            }
            Console.WriteLine("\nPoes ostmine:");
            float koguSumma = 0;

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                koguSumma += 1.5f; // Milk price
            }

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                koguSumma += 0.8f; 
            }

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            vastus = Console.ReadLine();
            if (vastus.ToLower() == "jah")
            {
                koguSumma += 1.2f;
            }

            Console.WriteLine("Ostetud kauba kogusumma on {0} eurot", koguSumma);
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
            Console.WriteLine("Switch tulemus: {0}", tekst);

            Console.WriteLine("\nVajuta suvalist klahvi lõpetamiseks...");
            Console.ReadKey();
        }
    }
}
