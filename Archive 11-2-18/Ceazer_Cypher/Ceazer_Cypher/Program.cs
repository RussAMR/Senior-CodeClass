using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceazer_Cypher
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
                    string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    int myint = 0;
                    for (int i = 0; i <= 25; i++)
                    {
                        Console.WriteLine(alpha[i]);
                        myint = alpha[i];
                        Console.WriteLine(myint);
                    }
                    string beta = "abcdefghijklmnopqrstuvwxyz";
                    for (int i = 0; i <= 25; i++)
                    {
                        Console.WriteLine(beta[i]);
                        myint = beta[i];
                        Console.WriteLine(myint);

                    }
                    if (x == 2)
                    {
                        converter();
                    }
                }
            } while (x != 0);
        }
        static int menu()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("1 = Run number's through upper case and lower case letters");
            Console.WriteLine("2 = Run converter for all existing char variables");
            Console.WriteLine("0 = Exit!");
            Console.WriteLine("*********************");
            int x;
            x = int.Parse(Console.ReadLine());
            return x;
        }
        static void converter()
        {
            for (int X = 0; X <= 13000; X++)
            {

                char mychar = (char)X;
                Console.Write(X + "=" + mychar);
            }
        }
    }
}
