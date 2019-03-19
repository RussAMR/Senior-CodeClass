using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recusion
{
    class Program
    {
        static void Main(string[] args)
        {
            if(CheckforPrime(0) == true)
            {
                Console.WriteLine("true");
            }
            if(CheckforPrime(0) == false)
            {
                Console.WriteLine("False");
            }
        }
        static bool CheckforPrime(int n, int divisor = 2)
        {
            if (n / divisor == 0)
            {
                return false;
            }
            if (divisor == n - 1)
            {
                return true;
            }

            return CheckforPrime(divisor + 1);
        }
    }
}
