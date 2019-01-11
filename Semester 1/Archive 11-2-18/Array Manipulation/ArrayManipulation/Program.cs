using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }


            int temp = array[0];
            array[0] = array[1];
            array[1] = temp;

            //The following can be used to test your implementations. Uncomment each line as you go to test.
            //NOTE: You don't have to do each line sequentially. For example, implementing the FindMin and FindMax methods
            //will be very useful for your FindRange method. Hint... Hint...

            Console.WriteLine("UNSORTED: ");
            PrintArray(array);
            Console.WriteLine("BUBBLE SORTED: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("SELECTION SORTED: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("MEAN: " + FindMean(array));
            Console.WriteLine("MEDIAN: " + FindMedian(SelectionSort(array)));
            Console.WriteLine("RANGE: " + FindRange(array));
            //Console.WriteLine("MODE: " + FindMode(array));
            Console.WriteLine("MAX: " + FindMax(array));
            Console.WriteLine("MIN: " + FindMin(array));
        }

        /// <summary>
        /// Prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">The array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name = "array" > The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            bool swaped;
            do
            {
                swaped = false;

                for (int i = 1; i <= mutatedArray.Length - 1; i++)
                    if (mutatedArray[i - 1] > mutatedArray[i])
                    {
                        int placer = mutatedArray[i - 1];
                        mutatedArray[i - 1] = mutatedArray[i];
                        mutatedArray[i] = placer;
                        swaped = true;
                    }
            } while (swaped != false);
            return mutatedArray;
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            int i, j;
            int n = mutatedArray.Length;
            for (j = 0; j < n - 1; j++)
            {
                int imin = j;
                for (i = j + 1; i < n; i++)
                {
                    if (mutatedArray[i] < mutatedArray[imin])
                    {
                        imin = i;
                    }
                }
                if (imin != j)
                {
                    int holder = mutatedArray[j];
                    mutatedArray[j] = mutatedArray[imin];
                    mutatedArray[imin] = holder;
                }
            }
            return mutatedArray;
        }

        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            float sum = 0;
            float mean;
            for (int count = 0; count < mutatedArray.Length; count++)
            {
                sum += mutatedArray[count];
            }
            mean = sum / mutatedArray.Length;
            return mean;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            float median = 0;
            if (array.Length % 2 == 0)
            {
                for (int count = 0; count < (mutatedArray.Length / 2); count++)
                {
                    for (int j = 0; j < (mutatedArray.Length / 2 + 1); j++)
                    {
                        median = mutatedArray[count] + mutatedArray[j];
                    }
                }
                median = median / 2;
                return median;
            }
            else
            {
                return array[array.Length / 2 - 1];
            }


        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            int Darras = array.Min();
            int Ryan = array.Max();
            int Range = Ryan - Darras;
            return Range;
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            int mode = 0;
            int counter = 0;
            int currentmodecount = 0;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        mode = array[i];
                        currentmodecount++;
                        
                    }
                    if(mode > array[i])
                    {
                        mode = array[i];
                        currentmodecount = 0;
                    }
                }
            }
            return mode;
        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            int max = array.Max();
            return max;

        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);
            int min = array.Min();
            return min;
        }
    }
}
