﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recusion_Alt_Difft
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                integers.Add(rand.Next(0, 1000));
            }
            integers.Sort();
            bool result = SearchIntList(integers, 0);
        }
        public static bool SearchIntList(List<int> integers,int n)
        {
            return SearchIntList
        }
        private static bool SearchIntListRecursive(List<int> integers,int n, int lowerBound, int upperBount)
        {


        }
    }
}