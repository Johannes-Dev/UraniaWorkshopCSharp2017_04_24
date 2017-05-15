using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto audi = new Auto();
            audi.KilometerStand = 100000;
            audi.Fahren(120);

            Auto bmw = new Auto();
            bmw.KilometerStand = 20000;
            bmw.Fahren(25);



            Console.WriteLine("Der BMW hat "+bmw.KilometerStand+"km auf dem Tacho");
            Console.ReadKey();

        }
    }
}
