using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Size_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            do
            {
                x = menu();
                if (x == 1)
                {
                    Square(int.Parse(Console.ReadLine()));
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Rectangle((int.Parse(Console.ReadLine())), (int.Parse(Console.ReadLine())));
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (x != 0);
         }

        static void Square(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int o = 0; o < size; o++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Rectangle(int size1, int size2)
        {

            for (int i = 0; i < size1; i++)
            {
                for (int o = 0; o < size2; o++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static int menu()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("#1 input square");
            Console.WriteLine("#2 input rectangle");
            Console.WriteLine("#0 to exit!");
            Console.WriteLine("*********************");
            int x;
            x = int.Parse(Console.ReadLine());
            return x;
        }
    }
}
