using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jA = new int[10][];
            for (int i = 0; i < jA.GetLength(0); i++)
            {
                jA[i] = new int[i + 1];
                for (int j = 0; j < jA[i].Length; j++)
                {
                    jA[i][j] = i * j;
                }
            }
            Print2DJaggedArray(jA);
        }
        static void Print2DJaggedArray(int[][] JaggedArray)
        {
            for (int l = 0; l < JaggedArray.GetLength(0); l++)
            {
                for(int p = 0; p < JaggedArray[l].Length; p++)
                {
                    Console.Write(JaggedArray[l][p] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
