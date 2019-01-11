using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_s
{
    class Program
    {
        static void Main(string[] args)
        {
            //Labeling array 1 and list 1
            int[] myIntArray = new int[10];
            List<int> myIntList = new List<int>();

            //For loop runing test on arrays
            for (int i = 0; i < 10; i++)
            {
                Random R = new Random();
                int L;
                L = R.Next();
                myIntArray[i] = L;
            }

            //For loop run test on list
            for (int I = 0; I < 10; I++)
            {
            
                myIntList.Add(I);
            }


            //labeling while loop assets
            int[] myIntArray2 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            List<int> myIntList2 = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            int UserInput1;
            int n = 0;


            //User input while loop for array and list tracking.
            while (n != 10)
            {
                Console.WriteLine("Please input number. :");
                UserInput1 = int.Parse(Console.ReadLine());
                myIntList2.Add(UserInput1);
                myIntArray2[UserInput1] = UserInput1;
                n++;
                Console.WriteLine("Currently on array #" + n);
            }
            Console.WriteLine("Clearing Array Entries");
            myIntArray[0] = 0;
            myIntArray2[0] = 0;

        }
    }
}