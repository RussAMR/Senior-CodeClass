using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string holder = "Hello";
            for (int i = 0; i < holder.Length/2; i++)
            {
                Console.WriteLine(holder[counter]);
              counter = counter + 2;
            }
        }
    }
}
