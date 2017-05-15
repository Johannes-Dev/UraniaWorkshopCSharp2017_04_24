using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GewinntUrania
{
    class Program
    {
        static void Main(string[] args)
        {
            var feld = new int[5, 7];
            IniFeld(feld);
            bool spielZuende = false;
            int spieler = 1;

            do
            {
                Console.Clear();
                ZeichneFeld(feld);
                Console.WriteLine("Spieler"+spieler+" bitte wähle eine Reihe.");
                int spalte = Convert.ToInt32(Console.ReadLine());
                SetzeStein(feld, spalte, spieler);

                if(IstSpielGewonnen(feld,spieler))
                {
                    spielZuende = true;
                    Console.WriteLine("Spieler" + spieler + " gewinnt :)");
                }

                if (spieler==1)
                {
                    spieler = 2;
                }
                else
                {
                    spieler = 1;
                }

            } while (!spielZuende);
            

            Console.ReadKey();
        }
        private static bool IstSpielGewonnen (int[,] feld,int spieler)
        {
            //treffer in spalte

            int treffer = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (feld[i,j]==spieler)
                    {
                        treffer++;
                        if (treffer == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        treffer = 0;
                    }
                }
                treffer = 0;
            }


            //treffer in zeile
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (feld[j, i] == spieler)
                    {
                        treffer++;
                        if (treffer == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        treffer = 0;
                    }
                }
                treffer = 0;
            }
            
            return false;
        }

        private static void SetzeStein(int[,] feld, int spalte, int Spieler)
        {
            for (int i = 4; i >= 0; i--)
            {
                if(feld[i,spalte]==0)
                {
                    feld[i, spalte] = Spieler;
                    break;
                }
            }
            //ToDoException
        }

        private static void IniFeld(int[,] feld)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    feld[i, j] = 0;
                }
            }
        }

        private static void ZeichneFeld(int[,] feld)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(feld[i, j]);
                }
                Console.Write("\n");
            }
        }
        
    }
}
