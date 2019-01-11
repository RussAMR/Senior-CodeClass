using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String_attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Helloworld = Console.ReadLine();
            int[] Reversalarray = new int[Helloworld.Length];
            for (int I = Helloworld.Length; I > 0; I--)
            {
                Console.Write(Helloworld[I - 1] + " ");
            }
        }
    }
}
