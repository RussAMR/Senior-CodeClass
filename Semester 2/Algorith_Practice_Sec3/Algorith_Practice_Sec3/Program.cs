using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorith_Practice_Sec3
{
    class Program
    {
        static void Main(string[] args)
        {
           Decrypt();
        }
        static void Decrypt()
        {
            List<string> Cypher = new List<string>();
            List<char> Secrettext = new List<char>();
                string line;
            int holder;
            string hold;
            string path;
            Console.WriteLine("Hello welcome to the caesar cypher reconverter");
            Console.WriteLine("Please input your shift # from -25 to 25");
            Console.WriteLine("Please input your Phrase");
            path = AppDomain.CurrentDomain.BaseDirectory + (@"Prob03.in_.txt");
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {

                    Cypher.Add(line);

                }
            }
            for (int X = 1; X <= Cypher.Count - 1; X++)
            {
                string[] array = Cypher[X].Split('-', ' ');
                for (int Z = 0; Z < array.Length; Z++)
                {
                    Secrettext.Add(Cypher[0][int.Parse(array[Z]) - 1]);
                }
                for (int P = 0; P <= Secrettext.Count - 1; P++)
                {
                    Console.Write(Secrettext[P]);                    
                }
                Secrettext.Clear();
                Console.WriteLine();
            }

        }
    }
}
