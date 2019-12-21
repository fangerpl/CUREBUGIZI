using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            const string ADDITION = "DODAWANIE", SUBTRATION = "ODEJMOWANIE", MULTIPLICATION = "MNOŻENIE", DIVISION = "DZIELENIE";
            string reply;

            int firstNum = 0,
                secondNum=0, 
                suma=0;

            Console.WriteLine("Co chcesz zrobić?\n({0}/{1}/{2}/{3})",ADDITION,SUBTRATION,MULTIPLICATION,DIVISION);
            Console.ForegroundColor = ConsoleColor.White;
            reply = Console.ReadLine();

            switch (reply)
            {
                case ADDITION:
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 1: ");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 2: ");
                        secondNum = Int32.Parse(Console.ReadLine());
                        for (int i=1; i<=9;i++)
                        {
                            if (i==1 || i==4 || i==7)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie.");
                            }
                            if (i==2 || i==5 || i==8)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie..");
                            }
                            if (i==3 || i==6 || i==9)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie...");
                            }
                        }

                        Thread.Sleep(1000);
                        Console.Clear();
                        suma = firstNum + secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Działanie:\n {0} + {1} = {2}", firstNum, secondNum, suma);
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Something went wrong! (FormatException)");
                        } while (suma == 0);
                    }
                    break;
                case SUBTRATION:
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 1: ");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 2: ");
                        secondNum = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i <= 9; i++)
                        {
                            if (i == 1 || i == 4 || i == 7)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie.");
                            }
                            if (i == 2 || i == 5 || i == 8)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie..");
                            }
                            if (i == 3 || i == 6 || i == 9)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie...");
                            }
                        }

                        Thread.Sleep(1000);
                        Console.Clear();
                        suma = firstNum - secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Działanie:\n {0} - {1} = {2}", firstNum, secondNum, suma);
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Something went wrong! (FormatException)");
                        } while (suma == 0);
                    }
                    break;
                case MULTIPLICATION:
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 1: ");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę nr 2: ");
                        secondNum = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i <= 9; i++)
                        {
                            if (i == 1 || i == 4 || i == 7)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie.");
                            }
                            if (i == 2 || i == 5 || i == 8)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie..");
                            }
                            if (i == 3 || i == 6 || i == 9)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie...");
                            }
                        }

                        Thread.Sleep(1000);
                        Console.Clear();
                        suma = firstNum * secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Działanie:\n {0} * {1} = {2}", firstNum, secondNum, suma);
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Something went wrong! (FormatException)");
                        } while (suma == 0);
                    }
                    break;
                case DIVISION:
                    try
                    {
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Podaj liczbę nr 1: ");
                            firstNum = Int32.Parse(Console.ReadLine());
                            if (firstNum == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nie mozesz dzielic przez zero! Spróbuj ponownie!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        } while (firstNum == 0);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Podaj liczbę nr 2: ");
                        secondNum = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i <= 9; i++)
                        {
                            if (i == 1 || i == 4 || i == 7)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie.");
                            }
                            if (i == 2 || i == 5 || i == 8)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie..");
                            }
                            if (i == 3 || i == 6 || i == 9)
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("Przeliczanie...");
                            }
                        }

                        Thread.Sleep(1000);
                        Console.Clear();
                        suma = firstNum / secondNum;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Działanie:\n {0} : {1} = {2}", firstNum, secondNum, suma);
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Something went wrong! (FormatException)");
                        } while (suma == 0);
                    }
                    break;
                default:
                    Console.Clear();
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Something went wrong! (Bad_join_data)");
                    } while (suma == 0);
                    break;
            }


            Console.ReadKey();
        }
    }
}
