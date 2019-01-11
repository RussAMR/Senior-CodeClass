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
    }

}
