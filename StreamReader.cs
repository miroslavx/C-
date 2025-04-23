using System;
using System.Collections.Generic;
using System.IO;

namespace FileHandlingDemo
{
   class Program
   {
       static void Main(string[] args)
       {
           string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
           
           // Kirjuta programmi abil 3 kuud faili
           try
           {
               using (StreamWriter sw = new StreamWriter(path))
               {
                   sw.WriteLine("Jaanuar");
                   sw.WriteLine("Veebruar");
                   sw.WriteLine("Juuni");
               }
           }
           catch (Exception)
           {
               Console.WriteLine("Mingi viga failiga");
               return;
           }
           // Loe kuud List<string> sisse
           List<string> kuude_list = new List<string>();
           try
           {
               foreach (string rida in File.ReadAllLines(path))
               {
                   kuude_list.Add(rida);
               }
           }
           catch (Exception)
           {
               Console.WriteLine("Viga failiga!");
               return;
           }
           
           // Eemalda "Juuni", muuda esimene element
           kuude_list.Remove("Juuni");
           if (kuude_list.Count > 0)
               kuude_list[0] = "Veeel kuuu";
               
           // Kuvada kõik kuud
           foreach (string kuu in kuude_list)
           {
               Console.WriteLine(kuu);
           }
           

           Console.WriteLine("Sisesta kuu nimi, mida otsida:");
           string otsitav = Console.ReadLine();
           if (kuude_list.Contains(otsitav))
               Console.WriteLine("Kuu " + otsitav + " on olemas.");
           else
               Console.WriteLine("Sellist kuud pole.");
               
           // Salvesta muudatused faili tagasi
           File.WriteAllLines(path, kuude_list);
           Console.WriteLine("Andmed on salvestatud.");
       }
   }
}
