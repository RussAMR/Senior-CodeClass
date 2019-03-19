using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorith_Practice_Sec3
{
    class Program
    {
        static void Main(string[] args)
        {

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
                PreCypher = Userinput[I]; n
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
    }
}
