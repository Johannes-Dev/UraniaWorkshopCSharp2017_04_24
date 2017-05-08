using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenraten
{
    class Program
    {
        static void Main(string[] args)
        {
            int minzahl;
            int maxzahl;
            int zufallszahl;
            bool nochmal = true;

            Console.WriteLine("Zahlenraten");
            Console.WriteLine("===============");
            Console.WriteLine("\n");

            //Console.WriteLine();
            //minzahl = Convert.ToInt32(Console.ReadLine());

            minzahl = IntegerFrage("Geben sie die Minzahl ein");            

            Console.WriteLine("Geben sie die Maxzahl ein");
            maxzahl = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Random rnd = new Random();
            zufallszahl = rnd.Next(minzahl, maxzahl);

            while (nochmal)
            {
                Console.WriteLine("Welche Zahl habe ich generiert?");
                int ratezahl = Convert.ToInt32(Console.ReadLine());

                if (ratezahl == zufallszahl)
                {
                    Console.WriteLine("Herzlichen Glückwusch :) Du hattest recht :)");
                    nochmal = false;
                }
                else
                {
                    //Console.WriteLine("Leider falsch. Wollen Sie noch einmal?(y)");
                    if (StringFrage("Leider falsch. Wollen Sie noch einmal?(y)") == "y")
                    {
                        nochmal = true;
                        if (zufallszahl < ratezahl)
                        {
                            Console.WriteLine("Kleiner Tipp: Die gesuchte Zahl ist kleiner als die getippte Zahl.");
                        }
                        else
                        {
                            Console.WriteLine("Kleiner Tipp: Die gesuchte Zahl ist größer als die getippte Zahl.");
                        }
                    }
                    else
                    {
                        nochmal = false;
                    }
                }
            }
            Console.WriteLine("Das Programm wurde beendet. Bis zum nächsten mal.");
            Console.ReadKey();
        }

        private static int IntegerFrage(string p_Frage)
        {
            Console.WriteLine(p_Frage);
            int ergebnis = Convert.ToInt32(Console.ReadLine());
            return ergebnis;
        }

        private static string StringFrage(string p_Frage)
        {
            Console.WriteLine(p_Frage);
            string ergebnis = Console.ReadLine();
            return ergebnis;
        }

    }
}
