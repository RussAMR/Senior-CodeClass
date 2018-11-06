using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezear_Cypher2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = -1;


            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("#1 Convert phrase to secondary");
                Console.WriteLine("#2 Convert phrase back to english");
                Console.WriteLine("#0 Exit");
                Console.WriteLine("************************");
                //menu
                menu = int.Parse(Console.ReadLine());

                //first converter
                if (menu == 1)
                {
                    Encrypor();
                    Console.WriteLine();
                }


                else if (menu == 2)
                {
                    Decrypt();
                    Console.WriteLine();

                }
                if (menu == 3)
                {
                    JailBreak();
                    Console.WriteLine();
                }
                Console.WriteLine("");
            } while (menu != 0);
        }
        static void Encrypor()
        {
            List<int> Cypher = new List<int>();
            List<char> Secrettext = new List<char>();
            List<char> Jailbreak = new List<char>();
            char Caesar;
            int PreCypher;
            string Userinput;
            int Shiftnum;

            Console.WriteLine("Hello welcome to the caesar Cypher program");
            Console.WriteLine("Please input your shift # from -25 to 25");
            Shiftnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your phrase");
            Userinput = Console.ReadLine();
            for (int I = 0; I <= Userinput.Length - 1; I++)
            {
                PreCypher = Userinput[I];
                Cypher.Add(PreCypher + Shiftnum);
            }
            for (int I = 0; I <= Userinput.Length - 1; I++)
            {
                if (Cypher[I] >= 123)
                {
                    Cypher[I] = Cypher[I] - 26;
                }
                else if (Cypher[I] <= 96)
                {
                    Cypher[I] = Cypher[I] + 26;
                }
                else
                {

                }
            }
            for (int X = 0; X <= Userinput.Length - 1; X++)
            {
                Caesar = (char)Cypher[X];
                Secrettext.Add(Caesar);

            }
            for (int P = 0; P <= Userinput.Length - 1; P++)
            {
                Console.Write(Secrettext[P]);
            }

        }
        static void Decrypt()
        {
            List<int> Cypher = new List<int>();
            List<char> Secrettext = new List<char>();
            List<char> Jailbreak = new List<char>();
            char Caesar;
            int PreCypher;
            string Userinput;
            int Shiftnum;

            Console.WriteLine("Hello welcome to the caesar cypher reconverter");
            Console.WriteLine("Please input your shift # from -25 to 25");
            Shiftnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your Phrase");
            Userinput = Console.ReadLine();
            for (int I = 0; I <= Userinput.Length - 1; I++)
            {
                PreCypher = Userinput[I];
                Cypher.Add(PreCypher - Shiftnum);
            }
            for (int I = 0; I <= Userinput.Length - 1; I++)
            {
                if (Cypher[I] >= 123)
                {
                    Cypher[I] = Cypher[I] - 26;
                }
                else if (Cypher[I] <= 96)
                {
                    Cypher[I] = Cypher[I] + 26;
                }
                else
                {

                }
            }
            for (int X = 0; X <= Userinput.Length - 1; X++)
            {
                Caesar = (char)Cypher[X];
                Secrettext.Add(Caesar);

            }
            for (int P = 0; P <= Userinput.Length - 1; P++)
            {
                Console.Write(Secrettext[P]);
            }
        }
        static void JailBreak()
        {
            List<int> Cypher = new List<int>();
            List<char> Secrettext = new List<char>();
            List<char> Jailbreak = new List<char>();
            char Caesar;
            int PreCypher;
            string Userinput;
            int Shiftnum;

            Console.WriteLine("Hello welcome to the caesar cypher  jailbreak converter");
            Console.WriteLine("Please input your Phrase");
            Userinput = Console.ReadLine();
            for (int X = 0; X <= Userinput.Length - 1; X++)
            {

            }
        }
    }
}
