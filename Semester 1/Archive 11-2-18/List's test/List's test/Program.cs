using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_s_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int myRand;
            List<int> MyRandList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                myRand = rand.Next(0,10);
                MyRandList.Add(myRand);
                Console.WriteLine(MyRandList[i]);
                Console.ReadKey();
            }
            List<int> MyRandList2 = new List<int>();
            int Userinput = 0;
            int X = 0;
            Console.WriteLine("You've been selected to put in random variables until you quit please type a random number :) :");
            while (X != 10)
            {
             Userinput = int.Parse(Console.ReadLine());
                MyRandList2.Add(Userinput);
                X++;
                
            }
            Console.WriteLine("I will now read out your list back to you");
            for (int I = 0; I < 10; I++)
            {

                Console.WriteLine(MyRandList2[I]);
                Console.ReadKey();
            }
        }
    }
}