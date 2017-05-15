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
            audi.Marke = "Audi";
            audi.Fahren(120);

            Auto bmw = new Auto();
            bmw.KilometerStand = 20000;
            bmw.Marke = "BMW";
            bmw.Fahren(25);

            var autos = new Auto[2];
            autos[0] = audi;
            autos[1] = bmw;

            for (int i= 0;i<2;i++)
            {
                if(autos[i].KilometerStand<50000)
                {
                    Console.WriteLine("Das Auto mit der Marke " + autos[i].Marke + " hat wenniger als 50000 Kilometer gefahren;");
                }
            }

            Console.ReadKey();

        }
    }
}
