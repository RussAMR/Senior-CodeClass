using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MDA = new int[10,5];
           
            for(int i = 0; i < MDA.GetLength(0); i ++)
            {
                for(int j = 0; j < MDA.GetLength(1); j++)
                {
                    MDA[i, j] = i * j;
                }
            }
            Print2Darray(MDA);
        }
        static void Print2Darray(int [,] MDA)
        {
            for (int i = 0; i < MDA.GetLength(0); i++ )
            {
                for (int j = 0; j < MDA.GetLength(1); j++)
                {
                    Console.Write(MDA[i,j] + "\t");
                }
                Console.WriteLine();
            }
           
        }
    }
}
