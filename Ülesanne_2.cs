using System;
using System.Collections.Generic;

namespace MaakonnadJaPealinnad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loo sõnastik maakondade ja pealinnade jaoks
            Dictionary<string, string> maakonnad = new Dictionary<string, string>();
            
            // Lisa algandmed
            maakonnad.Add("Harjumaa", "Tallinn");
            maakonnad.Add("Tartumaa", "Tartu");
            maakonnad.Add("Pärnumaa", "Pärnu");
            maakonnad.Add("Ida-Virumaa", "Jõhvi");
            maakonnad.Add("Lääne-Virumaa", "Rakvere");
            
            // Loo sõnastik pealinnade otsimiseks
            Dictionary<string, string> pealinnad = new Dictionary<string, string>();
            foreach (var paar in maakonnad)
            {
                pealinnad.Add(paar.Value, paar.Key);
            }
            
            bool jätka = true;
            while (jätka)
            {
                Console.WriteLine("\n=== Maakondade ja pealinnade programm ===");
                Console.WriteLine("1. Otsi pealinna järgi maakonda");
                Console.WriteLine("2. Otsi maakonna järgi pealinna");
                Console.WriteLine("3. Lisa uus maakond ja pealinn");
                Console.WriteLine("4. Mängi teadmiste testi");
                Console.WriteLine("5. Välju programmist");
                Console.Write("Vali tegevus (1-5): ");
                
                string valik = Console.ReadLine();
                
                switch (valik)
                {
                    case "1":
                        OtsiPealinnaJärgi(pealinnad);
                        break;
                        
                    case "2":
                        OtsiMaakonnaJärgi(maakonnad);
                        break;
                        
                    case "3":
                        LisaMaakondJaPealinn(maakonnad, pealinnad);
                        break;
                        
                    case "4":
                        MängiTesti(maakonnad);
                        break;
                        
                    case "5":
                        jätka = false;
                        Console.WriteLine("Programm lõpetab töö. Head aega!");
                        break;
                        
                    default:
                        Console.WriteLine("Vigane valik, proovi uuesti.");
                        break;
                }
            }
        }
        
        static void OtsiPealinnaJärgi(Dictionary<string, string> pealinnad)
        {
            Console.Write("Sisesta pealinna nimi: ");
            string pealinn = Console.ReadLine();
            
            if (pealinnad.ContainsKey(pealinn))
            {
                Console.WriteLine($"Pealinn {pealinn} asub maakonnas {pealinnad[pealinn]}");
            }
            else
            {
                Console.WriteLine($"Pealinna {pealinn} ei leitud andmebaasist.");
            }
        }
        
        static void OtsiMaakonnaJärgi(Dictionary<string, string> maakonnad)
        {
            Console.Write("Sisesta maakonna nimi: ");
            string maakond = Console.ReadLine();
            
            if (maakonnad.ContainsKey(maakond))
            {
                Console.WriteLine($"Maakonna {maakond} pealinn on {maakonnad[maakond]}");
            }
            else
            {
                Console.WriteLine($"Maakonda {maakond} ei leitud andmebaasist.");
            }
        }
        
        static void LisaMaakondJaPealinn(Dictionary<string, string> maakonnad, Dictionary<string, string> pealinnad)
        {
            Console.Write("Sisesta uue maakonna nimi: ");
            string maakond = Console.ReadLine();
            
            Console.Write("Sisesta selle maakonna pealinn: ");
            string pealinn = Console.ReadLine();
            
            if (!maakonnad.ContainsKey(maakond))
            {
                maakonnad.Add(maakond, pealinn);
                pealinnad.Add(pealinn, maakond);
                Console.WriteLine($"Lisatud: {maakond} - {pealinn}");
            }
            else
            {
                Console.WriteLine($"Maakond {maakond} on juba olemas!");
            }
        }
        
        static void MängiTesti(Dictionary<string, string> maakonnad)
        {
            Random rnd = new Random();
            int küsimusi = 5;
            int õigeid = 0;
            
            List<string> maakonnadList = new List<string>(maakonnad.Keys);
            
            for (int i = 0; i < küsimusi; i++)
            {
                int indeks = rnd.Next(maakonnadList.Count);
                string maakond = maakonnadList[indeks];
                string õigePealinn = maakonnad[maakond];
                
                Console.Write($"\nMis on maakonna {maakond} pealinn? ");
                string vastus = Console.ReadLine();
                
                if (vastus.ToLower() == õigePealinn.ToLower())
                {
                    Console.WriteLine("Õige vastus!");
                    õigeid++;
                }
                else
                {
                    Console.WriteLine($"Vale vastus! Õige vastus on {õigePealinn}.");
                }
            }
            
            double protsent = (double)õigeid / küsimusi * 100;
            Console.WriteLine($"\nSinu tulemus: {õigeid}/{küsimusi} õiget vastust ({protsent:F1}%)");
        }
    }
}
