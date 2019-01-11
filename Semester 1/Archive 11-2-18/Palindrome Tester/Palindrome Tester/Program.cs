using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palindrome = Console.ReadLine();
            string ReversePalindrome = "";
            Console.WriteLine(Palindrome.ToLower());
            Palindrome = Palindrome.ToLower();
            for (int I = Palindrome.Length - 1; I >= 0; I--)
            {
                ReversePalindrome += Palindrome[I];
            }
            Console.WriteLine(Palindrome + " " + ReversePalindrome);
            if (ReversePalindrome == Palindrome)
            {
                Console.WriteLine(Palindrome + " is a palindrome :)");
            }
            else
            {
                Console.WriteLine("This isn't a palindrome :(");
            }


            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
