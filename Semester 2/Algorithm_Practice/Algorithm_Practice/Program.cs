
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in_.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                float total = 0;
                while ((line = sr.ReadLine()) != null)
                {

                    if (line.Contains("QUARTER"))
                    {
                        line = line.Substring(8);
                        total += float.Parse(line) * .25f;
                    }
                    if (line.Contains("DIME"))
                    {
                        line = line.Substring(5);
                        total += float.Parse(line) * .10f;
                    }
                    if (line.Contains("NICKLE"))
                    {
                        line = line.Substring(7);
                        total += float.Parse(line) * .05f;
                    }
                    if (line.Contains("HALFDOLLAR"))
                    {
                        line = line.Substring(11);
                        total += float.Parse(line) * .50f;
                    }
                    if (line.Contains("PENNY"))
                    {
                        line = line.Substring(6);
                        total += float.Parse(line) * .01f;
                    }
                }
                Console.WriteLine(total);
                Console.ReadLine();
            }


        }

    }
}
