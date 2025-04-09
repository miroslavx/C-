using System;
using System.Text;

namespace Valikud
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Установка красного цвета текста для консоли
            Console.ForegroundColor = ConsoleColor.Red;
            bool jatka = true;

            while (jatka)
            {
                Console.Clear();
                Console.WriteLine("Valige ülesanne:");
                Console.WriteLine("1. Juku ja kinopiletid");
                Console.WriteLine("2. Pinginaabrid");
                Console.WriteLine("3. Toa pindala ja remont");
                Console.WriteLine("4. Hinnasoodustus");
                Console.WriteLine("5. Temperatuuri kontroll");
                Console.WriteLine("6. Inimese pikkuse kategooriad");
                Console.WriteLine("7. Pikkuse kategooriad soo järgi");
                Console.WriteLine("8. Poe ostud");
                Console.WriteLine("0. Väljuda");

                try
                {
                    int valik = int.Parse(Console.ReadLine());

                    switch (valik)
                    {
                        case 1:
                            JukuKino();
                            break;
                        case 2:
                            Pinginaabrid();
                            break;
                        case 3:
                            ToaRemont();
                            break;
                        case 4:
                            Hinnasoodustus();
                            break;
                        case 5:
                            Temperatuur();
                            break;
                        case 6:
                            InimesePikkus();
                            break;
                        case 7:
                            PikkusSugu();
                            break;
                        case 8:
                            PoeOstud();
                            break;
                        case 0:
                            jatka = false;
                            // Восстановление стандартных цветов консоли при выходе
                            Console.ResetColor();
                            break;
                        default:
                            Console.WriteLine("Vigane valik!");
                            break;
                    }

                    if (jatka)
                    {
                        Console.WriteLine("\nVajutage suvaline klahv jätkamiseks...");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Viga: " + ex.Message);
                    Console.WriteLine("\nVajutage suvaline klahv jätkamiseks...");
                    Console.ReadKey();
                }
            }
        }

        // 1. Ülesanne - Juku ja kinopiletid
        static void JukuKino()
        {
            Console.WriteLine("Mis on sinu nimi?");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme Jukuga kinno!");
                try
                {
                    Console.WriteLine("Kui vana sa oled, Juku?");
                    int vanus = int.Parse(Console.ReadLine());

                    if (vanus < 0 || vanus > 100)
                    {
                        Console.WriteLine("Viga andmetega!");
                    }
                    else if (vanus < 6)
                    {
                        Console.WriteLine("Sulle on tasuta pilet!");
                    }
                    else if (vanus >= 6 && vanus <= 14)
                    {
                        Console.WriteLine("Sulle on lastepilet!");
                    }
                    else if (vanus >= 15 && vanus <= 65)
                    {
                        Console.WriteLine("Sulle on täispilet!");
                    }
                    else
                    {
                        Console.WriteLine("Sulle on sooduspilet!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }
        }

        // 2. Ülesanne - Pinginaabrid
        static void Pinginaabrid()
        {
            Console.WriteLine("Sisesta esimese inimese nimi:");
            string nimi1 = Console.ReadLine();

            Console.WriteLine("Sisesta teise inimese nimi:");
            string nimi2 = Console.ReadLine();

            Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid!");
        }

        // 3. Ülesanne - Toa pindala ja remont
        static void ToaRemont()
        {
            Console.WriteLine("Sisesta toa pikkus (meetrites):");
            double pikkus = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta toa laius (meetrites):");
            double laius = double.Parse(Console.ReadLine());

            double pindala = pikkus * laius;
            Console.WriteLine($"Toa põranda pindala on {pindala} ruutmeetrit.");

            Console.WriteLine("Kas soovid teha remonti? (jah/ei)");
            string vastus = Console.ReadLine().ToLower();

            if (vastus == "jah")
            {
                Console.WriteLine("Kui palju maksab ruutmeeter (eurodes)?");
                double hind = double.Parse(Console.ReadLine());

                double koguHind = pindala * hind;
                Console.WriteLine($"Põranda vahetamise hind on {koguHind} eurot.");
            }
        }

        // 4. Ülesanne - Hinnasoodustus
        static void Hinnasoodustus()
        {
            Console.WriteLine("Sisesta 30% soodushinnaga hind:");
            double soodusHind = double.Parse(Console.ReadLine());

            // Kui soodushind on 70% alghinnast, siis alghind = soodushind / 0.7
            double alghind = soodusHind / 0.7;

            Console.WriteLine($"Alghind enne 30% soodustust oli {alghind} eurot.");
        }

        // 5. Ülesanne - Temperatuuri kontroll
        static void Temperatuur()
        {
            Console.WriteLine("Sisesta toatemperatuur (kraadides):");
            double temperatuur = double.Parse(Console.ReadLine());

            if (temperatuur > 18)
            {
                Console.WriteLine("Temperatuur on üle 18 kraadi, see on soovitav toasoojus talvel.");
            }
            else
            {
                Console.WriteLine("Temperatuur on 18 kraadi või madalam, see on alla soovitava toasoojuse talvel.");
            }
        }

        // 6. Ülesanne - Inimese pikkuse kategooriad
        static void InimesePikkus()
        {
            Console.WriteLine("Sisesta inimese pikkus (sentimeetrites):");
            double pikkus = double.Parse(Console.ReadLine());

            if (pikkus < 160)
            {
                Console.WriteLine("See inimene on lühike.");
            }
            else if (pikkus >= 160 && pikkus < 180)
            {
                Console.WriteLine("See inimene on keskmise pikkusega.");
            }
            else
            {
                Console.WriteLine("See inimene on pikk.");
            }
        }

        // 7. Ülesanne - Pikkuse kategooriad soo järgi
        static void PikkusSugu()
        {
            Console.WriteLine("Sisesta inimese pikkus (sentimeetrites):");
            double pikkus = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta inimese sugu (m/n):");
            string sugu = Console.ReadLine().ToLower();

            if (sugu == "m")
            {
                if (pikkus < 170)
                {
                    Console.WriteLine("See mees on lühike.");
                }
                else if (pikkus >= 170 && pikkus < 185)
                {
                    Console.WriteLine("See mees on keskmise pikkusega.");
                }
                else
                {
                    Console.WriteLine("See mees on pikk.");
                }
            }
            else if (sugu == "n")
            {
                if (pikkus < 160)
                {
                    Console.WriteLine("See naine on lühike.");
                }
                else if (pikkus >= 160 && pikkus < 175)
                {
                    Console.WriteLine("See naine on keskmise pikkusega.");
                }
                else
                {
                    Console.WriteLine("See naine on pikk.");
                }
            }
            else
            {
                Console.WriteLine("Vigane sugu sisestus. Palun kasuta 'm' meeste ja 'n' naiste jaoks.");
            }
        }

        // 8. Ülesanne - Poe ostud
        static void PoeOstud()
        {
            double koguHind = 0;

            Console.WriteLine("Kas soovid osta piima? (jah/ei)");
            string vastus = Console.ReadLine().ToLower();
            if (vastus == "jah")
            {
                koguHind += 1.50; // Piima hind
                Console.WriteLine("Piim lisatud ostukorvi: 1.50€");
            }

            Console.WriteLine("Kas soovid osta saia? (jah/ei)");
            vastus = Console.ReadLine().ToLower();
            if (vastus == "jah")
            {
                koguHind += 0.80; // Saia hind
                Console.WriteLine("Sai lisatud ostukorvi: 0.80€");
            }

            Console.WriteLine("Kas soovid osta leiba? (jah/ei)");
            vastus = Console.ReadLine().ToLower();
            if (vastus == "jah")
            {
                koguHind += 1.20; // Leiva hind
                Console.WriteLine("Leib lisatud ostukorvi: 1.20€");
            }

            Console.WriteLine($"Ostukorvi koguhind on {koguHind}€");
        }
    }
}