using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1_Begruessung
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string geschlecht = "";
            string begruessung = "Hallo";
            bool nochmal = true;

            while (nochmal)
            {

                Console.WriteLine("Name:");
                name = Console.ReadLine();
                Console.WriteLine("Geschlecht Frau(f) Herr(h):");
                geschlecht = Console.ReadLine();

                if (geschlecht == "h")
                {
                    Console.WriteLine(begruessung + " Herr " + name);
                    nochmal = false;
                }
                else if (geschlecht == "f")
                {
                    Console.WriteLine(begruessung + " Frau " + name);
                    nochmal = false;
                }
                else
                {
                    Console.WriteLine("Fehler? Nochmal? (y)");
                    //lesen von y ode n
                    //wenn ja dann nochmal = true
                    string wiederholung = Console.ReadLine();
                    if (wiederholung == "y")
                    {
                        // nochmal = true;
                    }
                    else
                    {
                        nochmal = false;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
