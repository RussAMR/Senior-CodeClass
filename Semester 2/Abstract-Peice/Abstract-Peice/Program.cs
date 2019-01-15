using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Peice.QuestClasses;

namespace Abstract_Peice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding the User interface and creating the quests
            int usinp;
            int Sidecounter = 0;
            int MainCount = 0;
            int DlC_count = 0;
            List<Quest> QuestDirect = new List<Quest>();
            //MainQuest
            QuestDirect.Add(new MainQuest(false, true, true, "The original starting quest for all players"));
            QuestDirect.Add(new MainQuest(false, true, true, "Quest #2 \"Enter the Abyss\""));
            QuestDirect.Add(new MainQuest(false, true, true, "Quest #3 \"Joining the ranks\""));
            QuestDirect.Add(new MainQuest(true, true, true, "Game Completed Would you like to start the Side Quests?"));
            //SideQuest
            QuestDirect.Add(new SideQuest(false, false, true, true, "The First side quest to exit in the game", 0));
            QuestDirect.Add(new SideQuest(true, false, true, true, "The game is completed well done...", 250));
            QuestDirect.Add(new SideQuest(false, false, false, false, "This Quest is currently Locked!", 100));
            QuestDirect.Add(new SideQuest(false, true, true, true, "Well done on finding the hidden input", 9000));
            //DlC
            QuestDirect.Add(new DLC(false, false, true, true, "Welcome to the DLC Quests three are contrained in this dlc including this one.", 25));
            QuestDirect.Add(new DLC(false, false, true, true, "DLC Quest 32", 50));
            QuestDirect.Add(new DLC(false, false, true, true, "Final DLC Quest", 75));
            Console.WriteLine("Welcome to Quest simulator what would you like to start with a Main or a Side quest?");
            do
            {
                Console.WriteLine("Press 0 to exit the Program");
                Console.WriteLine("Press 1 to start the Main Quest");
                Console.WriteLine("Press 2 to start the Side Quest(s)");
                Console.WriteLine("Press 3 to start the dlc if you know the code (Hint Hint 115)");
                usinp = int.Parse(Console.ReadLine());
                if (usinp == 1)
                {
                    if (MainCount == 0)
                    {
                        QuestDirect[0].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        MainCount++;
                    }
                    else if (MainCount == 1)
                    {
                        QuestDirect[1].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        MainCount++;
                    }
                    else if (MainCount == 2)
                    {
                        QuestDirect[2].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        MainCount++;
                    }
                    else if (MainCount == 3)
                    {
                        QuestDirect[3].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        MainCount++;
                    }
                }
                if (usinp == 2)
                {
                    if (Sidecounter == 0)
                    {
                        QuestDirect[4].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Sidecounter++;
                    }
                    else if (Sidecounter == 1)
                    {
                        QuestDirect[5].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Sidecounter++;
                    }
                    else if (Sidecounter == 2)
                    {
                        QuestDirect[6].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Sidecounter++;
                    }
                    else if (Sidecounter == 3 || Sidecounter == 4 || Sidecounter == 5 || Sidecounter == 6 || Sidecounter == 7 || Sidecounter == 8)
                    {
                        Console.WriteLine("Hint Hint, Run this a few more times and see what happens:3...This quest is level locked behind level 9000, it is uncompleted, and can't be made active!");
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Sidecounter++;
                    }
                    else if (Sidecounter == 10)
                    {
                        QuestDirect[7].ActiveQuest();
                        Console.WriteLine();
                        Console.WriteLine("press any key to continue:");
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        Sidecounter++;
                    }
                    else
                    {

                    }
                }
                if (usinp == 3)
                {
                    Console.WriteLine("Please enter your dlc pass code");
                    usinp = int.Parse(Console.ReadLine());
                    if (usinp == 115)
                    {
                        if (DlC_count == 0)
                        {
                            QuestDirect[8].ActiveQuest();
                            Console.WriteLine();
                            Console.WriteLine("press any key to continue:");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                            DlC_count++;
                        }
                        else if (DlC_count == 1)
                        {
                            QuestDirect[9].ActiveQuest();
                            Console.WriteLine();
                            Console.WriteLine("press any key to continue:");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                            DlC_count++;
                        }
                        else if (DlC_count >= 2)
                        {
                            QuestDirect[10].ActiveQuest();
                            Console.WriteLine();
                            Console.WriteLine("press any key to continue:");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                            DlC_count++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you don't own this dlc sorry...");
                    }
                }
            } while (usinp != 0);
        }
    }
}
