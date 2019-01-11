using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARussell_Compitency_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu_Variable;
            int Grade;
            int Counter;
            int Count_Num;
            int Reading_Level;
            int Userinput = 1;
            int sum;
            string Number5;
            int[] TheIntArray = new int[10];
            List<string> myStringLists = new List<string>() { };
            do
            {
                Console.WriteLine("******************************");
                Console.WriteLine("1: Conditionals ");
                Console.WriteLine("2: For loops");
                Console.WriteLine("3: While loops");
                Console.WriteLine("4: Arrays");
                Console.WriteLine("5: Lists");
                Console.WriteLine("-1: End the Program");
                Console.WriteLine("******************************");
                Menu_Variable = int.Parse(Console.ReadLine());
                if (Menu_Variable == 1)
                {
                    Console.Write("What Grade are you in? ");
                    Grade = int.Parse(Console.ReadLine( ));
                    Console.Write("What is your reading level ");
                    Reading_Level = int.Parse(Console.ReadLine());
                    if (Grade >= 9 - 12 && Reading_Level == Grade)
                    {
                        Console.WriteLine("You're in high school and your at a correct reading level :)");
                    }
                    else if (Grade >= 6 - 8 && Reading_Level == Grade)
                    {
                        Console.WriteLine("You're in middle school and your at a correct reading level :)");
                    }
                    else if (Grade == 1 - 5 && Reading_Level == Grade)
                    {
                        Console.WriteLine("You're in grade school and your at a correct reading level :)");
                    }
                    else if (Grade != 1 - 12)
                    {
                        Console.WriteLine("You're in college or higher you don't need to use me");
                    }
                    else if (Grade == 1 - 12 && Reading_Level < Grade)
                    {
                        Console.WriteLine("You need to go study get out of here");
                    }
                    else if (Grade == 1 - 12 && Reading_Level > Grade)
                    {
                        Console.WriteLine("Good job smarty");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
            if (Menu_Variable == 2)
                {
                    Console.WriteLine("What do you want to count by? ");
                    Counter = int.Parse(Console.ReadLine());
                    Console.WriteLine("What number do you want to count by " + Counter + " to? ");
                    Count_Num = int.Parse(Console.ReadLine());
                    for (int I = 0; I == Count_Num; I = Counter)
                    {
                        Console.WriteLine(I);
                    }
                }
            if (Menu_Variable == 3)
                {
                    sum = 0;
                    Console.WriteLine("Our sum starts at 0. Enter integer values to ad to, and the sum will print back out to you enter 0 to stop adding thank you");
                    while (Userinput != 0)
                    {
                        Console.WriteLine("Enter a value ");
                      Userinput = int.Parse(Console.ReadLine());
                      sum = sum + Userinput;
                      Console.WriteLine("New sum = " + sum);
                    }
                    Console.WriteLine("Exiting the loop your final sum equaled " + sum);
                }
            if (Menu_Variable == 4)
                {
                    Console.WriteLine(" You have an array of size 10 and of type int. Enter values to populate the array :)");
                    for (int I = 0; I < 10; I++)
                    {
                        Userinput = int.Parse(Console.ReadLine());
                        TheIntArray[I] = Userinput;
                        Console.WriteLine(Userinput + " Successfully added");
                    }
                    Console.WriteLine("All Array values added yay here they are back to you");
                    for (int I = 0; I < 10; I++ )
                    {
                        Console.WriteLine("Index " + I + " = " + TheIntArray[I]);
                    }
                }
            if (Menu_Variable == 5)
                {
                    Console.WriteLine("You have a string list enter values as long as you'd like and type end to end the program.");
                    Counter = 0;
                    do
                    {
                        
                        Console.WriteLine("Enter a string ");
                        Number5 = Console.ReadLine();
                        myStringLists.Add(Number5);
                    } while (Number5 != "end");
                    foreach(string s in myStringLists)
                    {
                        Console.WriteLine(" index " + Counter + " = " + s);
                        Counter++;
                    }
                }
            } while (Menu_Variable != -1);
        }
    }
}
