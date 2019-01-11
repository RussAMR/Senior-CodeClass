using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollercoaster_Attempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Passengerseat;
            int Userinput = 0;
            List<int> mypassengers = new List<int>(10);
            //Menu
            while (Userinput != 4)
            {
                Console.WriteLine("1. Put Rider in a random available");
                Console.WriteLine("2. List Available seats");
                Console.WriteLine("3. Start Ride, Print out how many people rode it.");
                Console.WriteLine("4. Exit Program");
                Userinput = int.Parse(Console.ReadLine());
                while (Userinput == 1)
                {
                    for (int I = 0; I < 1; I++)
                    {
                        Passengerseat = rand.Next(0, 10);
                        Console.WriteLine("Your seat number " + Passengerseat);
                        mypassengers.Add(Passengerseat);
                        Userinput = 0;
                    }
                }
                while (Userinput == 2)
                for (int I = 0; I < 1; I++)
                {
                    Console.WriteLine(mypassengers[I]);
                    Console.ReadLine();
                }
            }
        }
    }
}