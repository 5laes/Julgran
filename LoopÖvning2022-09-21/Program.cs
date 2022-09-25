using System;
using System.Threading;

namespace LoopÖvning2022_09_21
{
    class Program
    {
        //Metod som genererar random konsoltextfärg
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        

        static void Main(string[] args)
        {
            Random rd = new Random();
            Console.Write("\n\tSkriv en siffra" +
                "\n\t: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Är num mindre än tre krashar programmet
            if (num < 3)
            {
                num = 3;
            }

            //Används för att centrera alla "grenar" av granen
            int k;

            //Bestämmer toppen av granens storlek
            int divNumUpper = num / 3;
            //Besttämmer undre delen av granens storlek
            int divNumUnder = (num / 3) * 2;

            //Gör att granens undre del altid blir ett ojämnt tal så granen inte blir skev
            if ((divNumUnder / 2) % 2 != 0)
            {
                divNumUnder--;
            }

            //Printar granen
            do
            {
                for (int a = 0; a < 3; a++)
                {
                    //Används för att centrera alla "grenar" av granen
                    k = num + 1;

                    //Toppen av gran
                    if (a == 0)
                    {
                        for (int i = 0; i < divNumUpper; i++)
                        {
                            //Genererar random position för lamporna
                            int randomLights = rd.Next(1, divNumUpper);
                            int randomLights2 = rd.Next(1, divNumUpper);

                            //Används för att centrera alla "grenar" av granen
                            k--;

                            //Vänstersida gran
                            Console.Write("\t");
                            for (int x = k - (divNumUnder + divNumUpper) / 2; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < i; j++)
                            {
                                if (j == randomLights)
                                {
                                    Console.ForegroundColor = GetRandomConsoleColor();
                                    Console.Write("o");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }

                            //högersida gran
                            for (int j = 0; j <= i; j++)
                            {
                                if (j == randomLights2)
                                {
                                    Console.ForegroundColor = GetRandomConsoleColor();
                                    Console.Write("o");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen; 
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                            for (int x = k - (divNumUnder + divNumUpper) / 2; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }

                    //Undre delarna av granen
                    else
                    {
                        for (int i = divNumUnder; i < num; i++)
                        {
                            //Genererar random position för lamporna
                            int randomLights = rd.Next(1, divNumUpper);
                            int randomLights2 = rd.Next(1, divNumUpper);

                            //Används för att centrera alla "grenar" av granen
                            k--;

                            //Vänstersida gran
                            Console.Write("\t");
                            for (int x = k - divNumUnder; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < i - divNumUnder; j++)
                            {
                                if (j == randomLights)
                                {
                                    Console.ForegroundColor = GetRandomConsoleColor();
                                    Console.Write("o");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }

                            //högersida gran
                            for (int j = 0; j <= i - divNumUpper; j++)
                            {
                                if (j == randomLights2)
                                {
                                    Console.ForegroundColor = GetRandomConsoleColor();
                                    Console.Write("o");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                else
                                {
                                    Console.Write("*");
                                }
                            }
                            for (int x = k - divNumUnder; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                //Console.ReadLine();
                Thread.Sleep(1000);
                Console.Clear();
            } while (true);
        }
    }
}
