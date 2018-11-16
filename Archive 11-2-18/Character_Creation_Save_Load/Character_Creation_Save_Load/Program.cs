using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character_Creation_Save_Load
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void CharacterCreate(int luck, int strength, float height, int age, string name)
        {
            int age;
            float height;
            int luck;
            int strength;
            string Name;

            Console.WriteLine("What is your characters name.");
            Name = Console.ReadLine();
            Console.WriteLine("How old would you like to your character");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("How tall would you like to make your character? Feet.Inches");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("How much Luck 1-9 would you like?.");
            luck = char.Parse(Console.ReadLine());
            Console.WriteLine("How much Strength 1-9 would you like?");
            strength = int.Parse(Console.ReadLine());
            CharacterCreate(luck, strength, height, age, Name);

        }
        static void CharacterStatChanger(int luck, int strength, string name)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Character.txt";

            using (StreamReader sw = new StreamReader(path))

            Console.WriteLine(name + " has" + " " + luck + " would you like to change this skill?");
            luck = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " has" + " " + strength + "would you like to edit this skill?");
            strength = int.Parse(Console.ReadLine());
            return;            
        }
        static void SaveCharacter(Character character)
        {

            List<float> holding = new List<float>();

            string path = AppDomain.CurrentDomain.BaseDirectory + @"Character.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                holding.Add(luck);
                holding.Add(strength);
                holding.Add(height);
                holding.Add(age);
                sw.WriteLine(name);
                for (int i = 0; i < 4; i++)
                {
                    sw.WriteLine(holding[i]);
                }

            }
        }
    }
}

