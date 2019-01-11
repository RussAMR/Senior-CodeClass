using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("#1 5 + 6 ");
            Console.WriteLine("#2 11 + 13 ");
            Console.WriteLine("#3 3 + 9 ");
            Console.WriteLine("#4 End program");
            Console.WriteLine("********************************");

            int userinput = 0;

            do
            {
                userinput = int.Parse(Console.ReadLine());
                if (userinput == 1)
                {
                    addFive();
                    Console.WriteLine(" ");
                }
                else if (userinput == 2)
                {
                    addeleven();
                    Console.WriteLine(" ");
                }
                else if (userinput == 3)
                {
                    addthree();
                    Console.WriteLine(" ");
                }



            } while (userinput != 4);




        }




        static void addFive()
        {
            int num1 = 5;
        int num2 = 6;
            int numfull;
            numfull = num1 + num2;
            Console.WriteLine(" Resulting number is " + numfull );
        }

        static void addeleven()
        {
            int num1 = 11;
            int num2 = 13;
            int numfull;
            numfull = num1 + num2;
            Console.WriteLine("Resulting number is " + numfull);
        }

        static void addthree()
        {
            int num1 = 3;
            int num2 = 9;
            int numfull;
            numfull = num1 + num2;
            Console.WriteLine("Resulting number is " + numfull);
        }
    }

}
