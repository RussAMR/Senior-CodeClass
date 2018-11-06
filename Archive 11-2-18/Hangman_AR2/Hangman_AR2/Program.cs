using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_AR2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of words to select from
            string[] Word_list = new string[20];
            Word_list[0] = "Place";
            Word_list[1] = "heat";
            Word_list[2] = "delicous";
            Word_list[3] = "helpful";
            Word_list[4] = "cure";
            Word_list[5] = "handsomely";
            Word_list[6] = "smooth";
            Word_list[7] = "film";
            Word_list[8] = "damaged";
            Word_list[9] = "fish";
            Word_list[10] = "resonant";
            Word_list[11] = "chivalrous";
            Word_list[12] = "water";
            Word_list[13] = "jog";
            Word_list[14] = "soul";
            Word_list[15] = "eater";
            Word_list[16] = "imminent";
            Word_list[17] = "joyous";
            Word_list[18] = "doll";
            Word_list[19] = "profit";
            //create a random object
            int Randomword = 0;
            Random Words = new Random();
            Randomword = Words.Next(0, 20);
            //create a string to hold our randomly selected from the array word.
            string Hangman_word = "Hello";
            //create a list of characters to hold our guesses
            List<char> Letter_holder = new List<char>();
            //create a boolean to test wether or not our solution is currently correct
            //create a counter to count the number of failed guesses.
            int Counter = 6;
            //do-while failed guesses < 6 and sollution is not correct
            do
            {
                bool didwin = true;
                Hangman_word = Word_list[Randomword];
                Letter_holder.Add(char.Parse(Console.ReadLine()));
                for (int count = 0; count < Hangman_word.Length - 1; count++)
                {
                    if (Hangman_word.Contains(Letter_holder[count]))
                    {
                        Console.Write(Letter_holder[count]);
                    
                    }
                    else
                    {
                        Console.Write("_");
                        didwin = false;
                    }
                }
                for(int count2 = 0; count2 < Counter; count2++)
                {
                    Console.WriteLine(Letter_holder[count2]);
                }




            } while (Counter < 0);
            //Print out the hidden cersion of our string. If we print a single "_" then our solution is current not correct.

            //if out solution is currently not correct then
            //print to the user the guesses
            //Ask the user for input
            //if list of guesses does not contain the input then
            //Add input to list of guesses
            //if random word does not contain input then
            //increment failed guesses counter
            //end do-while

            //print out to the user the results of the game.

        }
    }
}
