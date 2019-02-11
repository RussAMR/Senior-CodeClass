using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice_Sec_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (line[i] > line[i + 1])
                        {
                            counter++;
                        }
                        else if(line[i] < line [i + 1])
                        {
                            counter--;
                        }
                    }
                    Console.WriteLine(line);
                }
            }
        }
    }
}
