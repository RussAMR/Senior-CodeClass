using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>() { 5, 5, 5, 5, 3, 2, 9 };
            List<int> L2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> L3 = new List<int>();

            L3 = L1.Intersect(L2).ToList();


            List<int> D1 = new List<int>() {8,6,7,5,3,0,9 };
            List<int> D2 = new List<int>();
            D2 = D1.Where(t => t >= 5 == true).ToList();
            for (int i = 0; i < D2.Count; i++)
            {
                Console.WriteLine(D2[i]);
            }

            L3 = L1.TakeWhile(t => t >= 5).ToList();
            
            foreach(int l in L3)
            {
                Console.Write(l);
            }
        }

    }
}
