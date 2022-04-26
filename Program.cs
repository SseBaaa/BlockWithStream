using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * using(Klasa objekt = new Klasa())
             * {
             *Naredbe koje se izvršavaju unutar bloka
             *na kraju bloka se poziva naredba objekt.Dispose()
             * }
             */

            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("\n ---------- commencing data transfer...");

            using (StreamWriter sv = new StreamWriter(@"C:\prviDir\mojaDatoteka.txt"))
            {
                sv.WriteLine("Ime: {0}", ime);
                sv.WriteLine("Prezime: {0}", prezime);
            }



            Console.WriteLine("Do you wanna see the contents of the file -y/n");
            string response = Console.ReadLine();
            if(response == "y")
            {
                Console.WriteLine("\n ---------- reading data...");
                using (StreamReader sr = new StreamReader(@"C:\prviDir\mojaDatoteka.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }

      

            Console.ReadKey();
        }
    }
}
