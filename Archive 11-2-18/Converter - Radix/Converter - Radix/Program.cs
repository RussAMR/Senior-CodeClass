using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter___Radix
{
    class Program
    {

        static void Main(string[] args)
        {
            int Radix = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            RadixClass(Radix, N);
            Console.ReadKey();


        }
        static void RadixClass(int Radix, int N)
        {
            if (N <= 0)
            {
                N = N * -1;
            }
            if (Radix == 0)
            {
                Console.WriteLine("ERROR ATTEMPTING TO DIVIDE BY ZERO");
                Radix = int.Parse(Console.ReadLine());
            }
            int Remander = N % Radix;
            int Quotiont = N / Radix;

            RadixClass(Quotiont, Radix);
            Remander = Remander + 94;

            char X = (char)Remander;
            Console.Write(X);

        }
    }
}
