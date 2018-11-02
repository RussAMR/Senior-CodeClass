using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int myRand;
            List<int> MyRandList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                myRand = rand.Next(0, 10);
                MyRandList.Add(myRand);
                Console.WriteLine(MyRandList[i]);
                Console.ReadKey();
            }
            for (int i = MyRandList.Count - 1; i > 0; i--)
            {
                MyRandList.RemoveAt(i);
            }
            int[] myIntArray = new int[10];
            for (int I = 0; I < 10; I++)
            {
                myIntArray[I] = 0;
            }
        }
    }
}
