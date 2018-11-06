using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_ARussell
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting the program with the title screen.
            Console.WriteLine("Hello Welcome to HANGMAN!");
            Console.WriteLine("You will have 6 trys to guess my word I will give you the amount of spaces");
            Console.WriteLine("I will tell you, your guessed letters and how many guesses you have remaining.");

            //Stating the values and the amount of turns left.
            string[] Word_list = new string[20];
            List<char> Letter_holder = new List<char>();
            string Hangman_word;
            //random counter
            int Randomword = 0;
            Random Words = new Random();
            Randomword = Words.Next(0, 20);
            bool didwin = true;
            //All the painful words
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
            
            //Starting the nonbasic code
            Hangman_word = Word_list[Randomword];
            Console.WriteLine("Your word is " + Hangman_word.Length + " letters long you have X guesses to guess the word :)");
            for (int i = Hangman_word.Length / 2; i >= 0; i--)
            {
                Console.WriteLine("You have " + i + " turns left");
                Letter_holder.Add(Console.ReadLine()[0]);
                if (Hangman_word.Contains(Letter_holder[Letter_holder.Count - 1]))
                {
                    i++;
                }
                didwin = true;
                for (int N = 0; N < Hangman_word.Length; N++)
                {

                    if (Letter_holder.Contains(Hangman_word[N]))
                    {
                        Console.Write(Hangman_word[N]);
                    }
                    else
                    {
                        Console.Write("_");
                        didwin = false;
                    }
                }
                if (didwin == true)
                {
                    break;
                }
            }
            if (didwin == true)
            {
                Console.WriteLine("you win! :)");
            }
            else
            {
                Console.WriteLine("you lost :(");
            }

        }
    }
}