 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint;
            int Uinput;
            Stack Mystack = new Stack();

            do
            {

                Console.Clear();
                Console.WriteLine("***Type 0 to Exit the program");
                Console.WriteLine("***Type 1 to add a value to your stack***");
                Console.WriteLine("***Type 2 to print the top value***");
                Console.WriteLine("***Type 3 to remove a value and print it***");
                Console.WriteLine("***Type 4 to print the whole stack***");
                Uinput = int.Parse(Console.ReadLine());
                if(Uinput == 1)
                {
                    Console.WriteLine("What value would you like to add");
                    myint = int.Parse(Console.ReadLine());
                    Mystack.Push(myint);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if(Uinput == 2)
                {
                    myint = Mystack.Peak();
                    Console.WriteLine(myint + " is the top value");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if(Uinput == 3)
                {
                    myint = Mystack.Pop();
                    Console.WriteLine(myint + " has been popped");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if(Uinput == 4)
                {
                    Mystack.Print();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }



            } while (Uinput != 0);  
        }
    }
}
