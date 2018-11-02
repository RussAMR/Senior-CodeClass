using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARussell_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Naming all of the basic assets

            string Palindrome = Console.ReadLine();
            int[] Reversalarray = new int[Palindrome.Length];
            Console.WriteLine(Palindrome.ToLower());

            //Starting the for loop
            for (int I = Palindrome.Length; I > 0; I--)
            {
                Console.Write(Palindrome.ToLower()[I - 1]);
            }

            //Running the checker
            {
            
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
