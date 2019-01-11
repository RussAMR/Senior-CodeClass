using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
         int I = 0;
         int N = 0;
            int Menu = 0;
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("#1 X");
            Console.WriteLine("#2 Square 3x3");
            Console.WriteLine("#3 Square 5x5");
            Console.WriteLine("#4 Left side Triangle");
            Console.WriteLine("#5 Right side Triangle");
            Console.WriteLine("#6 X cube");
            Console.WriteLine("#7 Right to Left slash");
            Console.WriteLine("#8 Left to Right slash");
            Console.WriteLine("#9 Exit");
            while (Menu != 9)
            {
                Menu = int.Parse(Console.ReadLine());

                if (Menu == 1)
                {
                    for (I = 0; I < 1; I++)
                    {
                        Console.WriteLine("X");
                    }
                    Console.WriteLine(" ");
                }
                if (Menu == 2)
                {
                    for (I = 0; I < 3; I++)
                    {
                        for (N = 0; N < 3; N++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                }
                if (Menu == 3)
                {
                    for (I = 0; I < 4; I++)
                    {
                        for (N = 0; N < 5; N++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                }
                if (Menu == 4)
                {
                    for (I = 0; I < 6; I++)
                    {
                        for (N = 0; N < I; N++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                }
                if (Menu == 5)
                {
                    for (I = 0; I < 5; I++)
                    {
                        for (N = 0; N < 5; N++)
                        {
                            if (4 - N <= I)
                            {
                                Console.Write("X");
                            }
                            else Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                if (Menu == 6)
                {
                    for (I = 0; I < 5; I++)
                    {
                        for (N = 0; N < 5; N++)
                        {
                            if (I == N || 4 - N == I)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine(" ");
                }
                if (Menu == 7)
                {
                    for (I = 0; I < 5; I++)
                    {
                        for (N = 0; N < 5; N++)
                        {
                            if (I == N)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                }
                if (Menu == 8)
                {
                    for (I = 0; I < 5; I++)
                    {
                        for (N = 0; N < 5; N++)
                        {
                            if (4 - N == I)
                                Console.Write(" ");
                            else
                                Console.Write("X");
                        }
                        Console.WriteLine(" ");
                    }
                }
            }
        }
    }
}
