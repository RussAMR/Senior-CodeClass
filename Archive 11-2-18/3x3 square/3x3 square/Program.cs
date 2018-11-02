using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x3_square
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Print3x3Square();
                Console.WriteLine();
                Print3x6Rectangle();
                Console.WriteLine();
                Print3x6Rectangle2();
                Console.ReadKey();
            }

        }
        static void Print3x3Square()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Print3x6Rectangle()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Print3x6Rectangle2()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }

    }
}
