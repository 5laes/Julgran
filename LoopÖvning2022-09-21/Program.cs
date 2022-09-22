using System;
using System.Threading;

namespace LoopÖvning2022_09_21
{
    class Program
    {
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
            int k;
            int[] random = new int[3];
            random[0] = rd.Next(num / 2, num);
            random[1] = rd.Next(1, num / 2);
            random[2] = rd.Next(1, num / 2);

            do
            {
                for (int a = 0; a < 3; a++)
                {
                    k = num + 1;
                    //Toppen av gran
                    if (a == 0)
                    {
                        for (int i = 0; i < random[a]; i++)
                        {
                            int randomLights = rd.Next(1, num);
                            int randomLights2 = rd.Next(1, num);
                            k--;
                            //Vänstersida gran
                            Console.Write("\t");
                            for (int x = k; x > 1; x--)
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
                            for (int x = k; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }

                    //Undre delarna av granen
                    else
                    {
                        for (int i = random[a]; i < num; i++)
                        {
                            int randomLights = rd.Next(1, num);
                            int randomLights2 = rd.Next(1, num);
                            k--;
                            //Vänstersida gran
                            Console.Write("\t");
                            for (int x = k - random[a]; x > 1; x--)
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
                            for (int x = k - random[a]; x > 1; x--)
                            {
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                //Console.ReadLine();
                Thread.Sleep(666);
                Console.Clear();
            } while (true);
        }
    }
}
