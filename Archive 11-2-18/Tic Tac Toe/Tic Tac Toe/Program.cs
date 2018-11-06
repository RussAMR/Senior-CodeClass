using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] JA = new string[1][];
            Console.WriteLine("Type 1 for (3x3) type 2 for (4x4)");
            int UInp = int.Parse(Console.ReadLine());
            if (UInp == 1)
            {
               for(int p = 0; p < 3; p++ )
                {
                    for(int i = 0; i < 4; i++)
                    {
                        Console.Write("|" + " ");
                    }
                    Console.WriteLine();
                }
            }
           








        }
    }
}
