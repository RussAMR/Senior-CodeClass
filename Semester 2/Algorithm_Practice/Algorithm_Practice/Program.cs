
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
            int myint;
            using (StreamReader sw =  new StreamReader(path))
            {
                myint = int.Parse(sw.ReadLine());
                
            }
            if(myint == 31)
            {
                Console.WriteLine("Quarters");
            }
        }
    }
}
