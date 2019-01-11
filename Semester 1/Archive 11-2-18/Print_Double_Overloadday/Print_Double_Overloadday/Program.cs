using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Double_Overloadday
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = Math.PI;

            PDO(f);
        }
        static void PDO(double x, int y = 2)
        {
            string s = "0.";
            int prisisionvar = y;
            for (int i = 0; i < y - 1; i++)
            {
                s = s + "#";
            }
            //expected output of 3.14
            string printval = x.ToString(s);

            Console.WriteLine(printval);
        }
    }
}
