using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            int Usp;
            do
            {
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Add two integers from user input together");
                Console.WriteLine("3. Calulcate the area of a circle given just the radius from user input");
                Console.WriteLine("4. Calculate the area of a triangle given the length of all three sides from user input");
                Console.WriteLine("5. Given an integer n from user input, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6. Given an integer n from user input, draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7. Given two integer variables from user input, swap their values");
                Console.WriteLine("8. Reverse a string from user input using a for loop");
                Console.WriteLine("0. End the program");
                Menu(Usp = int.Parse(Console.ReadLine()));
            } while (Usp == 0);



        }
        static void Menu(int usp)
        {
            if (usp == 1)
            {
                Console.WriteLine("Hello World");
            }
            if(usp == 2)
            {
                int holder;
                int holder2;
                int full;
                holder = int.Parse(Console.ReadLine());
                holder2 = int.Parse(Console.ReadLine());

                full = holder + holder2;
                Console.WriteLine("Your sum is" + full);
            }
            if(usp == 3)
            {
                int val = int.Parse(Console.ReadLine());
                double val2 = Math.PI * (Math.Pow(val,2));
            }
            if(usp == 4)
            {
                int Perimeter;
                double Area;
                Console.WriteLine("Welcome to the three sided triangle calculations please input your first side.");
                int side1 = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your Second Side?");
                int side2 = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your Third side?");
                int side3 = int.Parse(Console.ReadLine());

                Perimeter = (side1 + side2 + side3) / 2;
                Console.WriteLine("Your Perimeter is " + Perimeter);

                int holder = (Perimeter * (Perimeter - side1) * (Perimeter - side2) * (Perimeter - side3));
                Area = Math.Sqrt(holder);
                Console.WriteLine("Your area is " + Area);
            }
            if(usp == 5)
            {
                int Xsp = int.Parse(Console.ReadLine());
                for (int I = 0; I < Xsp; I++)
                {
                    for (int N = 0; N < Xsp; N++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
            if(usp == 6)
            {
                int Xsp = int.Parse(Console.ReadLine());
                for (int i = 0; i < Xsp; i++)
                {
                    for (int D = 0; D < Xsp; D++)
                    {

                        if(D == 0 || i <= 0 || i == Xsp - 1 || D == Xsp - 1 )
                        {
                            Console.Write("X");
                        }

                        else
                        {
                            Console.Write(" ");
                        }                          
                    }
                    Console.WriteLine(" ");
                }
            }
            if(usp == 7)
            {
                int x;
                int y;
                int holder;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                holder = x;
                x = y;
                y = holder;
                
            }
            if (usp == 8)
            {
            List<char> revstring = new List<char>();
            string holder = Console.ReadLine();
                for (int i = holder.Length - 1; i > -1; i--)
                {
                    revstring.Add(holder[i]);
                }
                for (int d = 0; d < revstring.Count; d++)
                {
                    Console.Write(revstring[d]);
                }
                Console.WriteLine("");
            
            }
        }
    }
}
