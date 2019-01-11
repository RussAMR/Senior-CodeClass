using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] b = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print(rand.Next(1, 10));
            Console.WriteLine();
            Print(b);
            Console.WriteLine();
            int[,] c = new int[10, 5];
            for (int i = 0; i < c.GetLength(0); i++)
            {

                for (int K = 0; K < c.GetLength(1); K++)
                {
                    c[i,K] = rand.Next(1, 10);
                }
            }
            Print(c);
            Console.WriteLine();
            int[][] D = new int[10][];
            for (int i = 0; i < D.GetLength(0); i++)
            {
                D[i] = new int[i + 1];
                for (int J = 0; J < D[i].Length; J++)
                {
                    D[i][J] = i * J;
                }
            }
            Console.WriteLine();
            Print(D);
        }
        static void Print(int a)
        {
            Console.WriteLine(a);           
        }
        static void Print(int[] array)
        {

            for(int I = 0; I < array.Length; I++)
            {

                Console.Write(array[I]);
            }
        }
        static void Print(int[,] array)
        {
            for(int I = 0; I < array.GetLength(0); I++)
            {
                Console.WriteLine();
                for(int J = 0; J < array.GetLength(1); J++)
                {
                    Console.Write(array[I, J]);
                }
                
            }
        }
        static void Print(int[][] array)
        {
            for (int I = 0; I < array.GetLength(0); I++)
            {
                for (int J = 0; J < array[I].Length; J++)
                {
                    Console.Write(array[I][J] + "\t");
                }
                Console.WriteLine();
            }
        }       
    }
}
