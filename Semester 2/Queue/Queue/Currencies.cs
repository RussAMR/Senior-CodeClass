using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Currencies : IComparable<Currencies>
    {
        int GoldCount = 0;
        int SilverCount = 0;
        int CopperCount = 0;

        public Currencies(int GoldCount, int SilverCount, int CopperCount)
        {
            this.GoldCount = GoldCount;
            this.SilverCount = SilverCount;
            this.CopperCount = CopperCount;
        }
        public int CompareTo(Currencies other)
        {
            if (other == null)
            { return 1; }
            int total = GoldCount * 10000 + SilverCount * 100 + CopperCount;
            int othertotal = other.GoldCount * 10000 + other.SilverCount * 100 + other.CopperCount;
            return total > othertotal ? 1 : total < othertotal ? -1 : 0;
        }
        public void Print()
        {
            Console.WriteLine("You have " + GoldCount + "Gold coins you have" + SilverCount + "Silver coins and you have " + CopperCount + "Copper coins");
        }
    }
}
