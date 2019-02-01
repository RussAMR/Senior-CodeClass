using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_Quest_Set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + (@"Prob01.in.txt");
            using (StreamReader sw = new StreamReader(path))
            {
                sw.ReadLine();
                while (sw.Peek() > -1)
                {
                    string x = sw.ReadLine();
                    if(int.Parse(x) >= 70)
                    {
                        Console.WriteLine("Pass");
                    }
                    else
                    {
                        Console.WriteLine("Fail");

                    }
                }

            }

            Console.ReadKey();

        }
    }
}
