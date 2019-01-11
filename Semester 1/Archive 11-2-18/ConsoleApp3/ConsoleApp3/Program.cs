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
            int[] myintArray = new int[10];
            Random R = new Random();
            int seed;
            for (int i = 0; i < myintArray.Length; i++)
            {

                seed = R.Next(0,10);
                for(int K = 0; K < myintArray.Length; K++)
                myintArray[i] = seed;
            }
            
            for(int i = 0; i < myintArray.Length; i++)
            {
                for (int K = 0; K < myintArray.Length; K++)
                {
                    if (myintArray[i] < myintArray[K])
                    {
                        int holder = myintArray[i];
                        myintArray[i] = myintArray[K];
                        myintArray[K] = holder;
                    }
                }
            }
            for(int L = 0; L < myintArray.Length; L++)
            {
                Console.Write(myintArray[L]  + ", ");
            }
            Console.ReadKey();
        }
    }
}
