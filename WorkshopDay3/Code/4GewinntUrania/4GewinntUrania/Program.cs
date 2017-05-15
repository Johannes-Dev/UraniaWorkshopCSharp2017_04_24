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
            var feld = new char[5, 7];
            IniFeld(feld);
            bool spielZuende = false;
            char spieler = 'r';//welcher spieler ist am zug

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

                if (spieler=='r')
                {
                    spieler = 'g';
                }
                else
                {
                    spieler = 'r';
                }

            } while (!spielZuende);
            

            Console.ReadKey();
        }
        private static bool IstSpielGewonnen (char[,] feld,char spieler)
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

        private static void SetzeStein(char[,] feld, int spalte, char Spieler)
        {
            for (int i = 4; i >= 0; i--)
            {
                if(feld[i,spalte]=='w')
                {
                    feld[i, spalte] = Spieler;
                    break;
                }
            }
            //ToDoException
        }




        private static void IniFeld(char[,] feld)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    feld[i, j] = 'w';
                }
            }
        }

        private static void ZeichneFeld(char[,] feld)
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
