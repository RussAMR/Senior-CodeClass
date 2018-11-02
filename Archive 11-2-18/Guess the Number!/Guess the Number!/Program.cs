using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number_
{
    class Program
    {
        static void Main(string[] args)

        {
            //This will keep the program running until the person guesses the right number and then tells the user how many guess it took.

            //This will give me a random number to use that the computer will hold for the process.
            Random Randomvariable = new Random();
            int GuessingGame;
            GuessingGame = Randomvariable.Next(0,1000);
            int Userinput = 0;
            int Counter = 0;
            int Max = 1000;
            int Min = 0;
            int avg;
            //There will be a do while running until your answer ='s the computer.
            do
            {
                avg = ((Min + Max) / 2);
                Console.WriteLine("I'd suggest " + avg + " but thats just me.");
                //This will get the persons input and find out if it's high or lower and then give them a text response for higher or lower.
                Userinput = int.Parse(Console.ReadLine());
                //Using this if statement right here will test to see if the number guessed is higher or lower and then give them their output and resets, and asks for a new number.
                if (Userinput < GuessingGame)
                {
                    Console.WriteLine("Your guess is less than the Correct Value");
                    Console.WriteLine(" ");
                    Min = Userinput;
                }
                else if (Userinput > GuessingGame)
                {
                    Console.WriteLine("Your guess is higher than the Correct Value");
                    Console.WriteLine(" ");
                    Max = Userinput;
                }
                Counter++;
            } while (Userinput != GuessingGame);
            //End program.
            Console.WriteLine("It took you " + Counter + " Guesses To guess my number of " + GuessingGame);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}