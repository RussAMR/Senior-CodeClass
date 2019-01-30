using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_Quest_Set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades grades = new Grades();
            List<Grades> CallItWhatever = new List<Grades>();
            int myint;
            string path = AppDomain.CurrentDomain.BaseDirectory + (@"Prob01.in.txt");
            using (StreamReader sw = new StreamReader(path))
            {
                Grades.grades1 = sw.ReadLine();
            }

            

        }
    }
}
