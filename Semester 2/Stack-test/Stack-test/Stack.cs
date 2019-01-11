using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_test
{
    class Stack
    {
        List<int> Holder = new List<int>();

        public Stack()
        {

        }
        //push
        public void Push(int val)
        {
            Holder.Add(val);
        }
        //pop
        public int Pop()
        {
            if (Holder.Count > 0)
            {
                int myint;
                myint = Holder.Last();
                Holder.RemoveAt(Holder.Count() - 1);
                return myint;
            }
            else
            {
                Console.WriteLine("Stack Underflow (No values left in the list)");
                return 0;
            }
        }
        //peak
        public int Peak()
        {
            if (Holder.Count > 0)
            {
                int myint;
                myint = Holder.Last();
                return myint;
            }
            else
                Console.WriteLine("There's nothing in HERE!");
            return 0;
        }
        //print
        public void Print()
        {
            for (int i = 0; i < Holder.Count; i++)
            {
                Console.WriteLine(Holder[i] + ",");              
            }
        }

        public List<int> Search(int val)
        {
            List<int> Positions = new List<int>();
            if (Holder.Contains(val))
            {
                for (int i = 0; i < Holder.Count -1; i++)
                {
                    val = Holder[i];
                    Positions.Add(val);
                    Console.WriteLine("Holder Contains this variable at " + i +"The value is " + val);
                }
            }
            else
            {
                Console.WriteLine("this variable isn't contained in the program");
            }
            return Positions;
        }
    }

}
