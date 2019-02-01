using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AEIOU_Code_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;

            int value = 0;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in.txt";
            using (StreamReader sw = new StreamReader(path))
            {
                sw.ReadLine();
                while (sw.Peek() > -1)
                {
                    x = sw.ReadLine();
                    if (x.Contains('a') || x.Contains('e') || x.Contains('i') || x.Contains('o') || x.Contains('u'))
                    {
                        value += x.Count(f => f == 'a');
                        value += x.Count(f => f == 'e');
                        value += x.Count(f => f == 'i');
                        value += x.Count(f => f == 'o');
                        value += x.Count(f => f == 'u');
                    }
                    Console.WriteLine(value);
                    value = 0;
                }

            }
            Console.ReadKey();
        }
    }
}
