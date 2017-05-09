using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           var feld = new int[5,5];
            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    feld[i, j] = 0;
                }
            }

            feld[2, 3] = 1;
            
            ausgabe(feld);



            Console.ReadKey();

        }


        private static  void ausgabe(int[,] feld)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(feld[i, j]);
                }
                Console.Write("\n");
            }

        }
    }
}
