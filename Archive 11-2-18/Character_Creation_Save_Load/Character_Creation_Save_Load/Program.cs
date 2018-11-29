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
            int userinput;
            List<Character> character = new List<Character> { };
            do
            {
                userinput = Menu();
                if (userinput == 1)
                {
                    character.Add(CharacterCreate());
                }
                if (userinput == 2)
                {
                    Character charactor = new Character);
                    Console.WriteLine("What chracter would you like to change?");
                    string hold = Console.ReadLine();
                    for (int i = 0; i < character.Count; i++)
                    {
                        if (character.name[i] = hold)
                        {

                        }

                    }
                    CharacterStatChanger();
                }
                if (userinput == 3)
                {
                    LoadCharacter(CharacterCreate());
                }
                if (userinput == 4)
                {
                    DeleteCharacter(CharacterCreate());
                }
                if (userinput == 5)
                {
                    SaveCharacter(CharacterCreate());
                }

            } while (userinput != 0);

        }
        static int Menu()
        {
            int userinput;
            Console.WriteLine("***** Hello Welcome to the character creation system :)*****");
            Console.WriteLine("***** Type 1 to start the process *****");
            Console.WriteLine("***** Type 2 if you want to change certain value's of your character*****");
            Console.WriteLine("***** Type 3 if you would like to load an old character*****");
            Console.WriteLine("***** Type 4 if you would like to delete your old save*****");
            Console.WriteLine("***** Type 5 to overwrite your old character*****");
            Console.WriteLine("***** Type 0 to quit*****");
            userinput = int.Parse(Console.ReadLine());
            return userinput;
        }
        static void Menu2(int userinput)
        {

        }

        static Character CharacterCreate()
        {

            Console.WriteLine("What is your characters name.");
            string Name = Console.ReadLine();
            Console.WriteLine("How old would you like to your character");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("How tall would you like to make your character? Feet.Inches");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("How much Luck 1-9 would you like?.");
            int luck = char.Parse(Console.ReadLine());
            Console.WriteLine("How much Strength 1-9 would you like?");
            int strength = int.Parse(Console.ReadLine());
            Character rtnobj = new Character(luck, strength, height, age, Name);
            return rtnobj;
        }
        static Character CharacterStatChanger(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";

            using (StreamReader sw = new StreamReader(path))
            {
                character.Name = sw.ReadLine();
                character.luck = sw.ReadLine()[1];
                character.height = sw.ReadLine()[2];
                character.strength = sw.ReadLine()[3];
                character.age = sw.ReadLine()[4];
            }

            Console.WriteLine(character.Name + " has" + " " + character.luck + " would you like to change this skill?");
            character.luck = int.Parse(Console.ReadLine());
            Console.WriteLine(character.Name + " has" + " " + character.strength + "would you like to edit this skill?");
            character.strength = int.Parse(Console.ReadLine());
            Character hlder = new Character(character.luck, character.strength, character.height, character.age, character.Name);
            return hlder;
        }
        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("This file already exists would you like to overwrite?");
                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.Name);
                        sw.WriteLine(character.luck);
                        sw.WriteLine(character.height);
                        sw.WriteLine(character.strength);
                        sw.WriteLine(character.age);
                    }
                    Console.WriteLine("File has been overwritten");
                }
                else
                {
                    Console.WriteLine("File is unchanged");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.Name);
                    sw.WriteLine(character.luck);
                    sw.WriteLine(character.height);
                    sw.WriteLine(character.strength);
                    sw.WriteLine(character.age);
                }
            }
        }
        static bool DeleteCharacter(Character character)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            else
            {
                return true;
            }
        }
        static Character LoadCharacter(Character character)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + character.Name + ".txt";

            if (File.Exists(path))
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    int luck;
                    int strength;
                    float height;
                    int age;
                    string name;
                    name = sw.ReadLine();
                    luck = sw.ReadLine()[1];
                    height = sw.ReadLine()[2];
                    strength = sw.ReadLine()[3];
                    age = sw.ReadLine()[4];
                    Character Hlder = new Character(luck, strength, height, age, name);
                    return Hlder;
                }
            }
            else
            {
                Console.WriteLine("What is your characters name.");
                string Name = Console.ReadLine();
                Console.WriteLine("How old would you like to your character");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("How tall would you like to make your character? Feet.Inches");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("How much Luck 1-9 would you like?.");
                int luck = char.Parse(Console.ReadLine());
                Console.WriteLine("How much Strength 1-9 would you like?");
                int strength = int.Parse(Console.ReadLine());
                Character rtnobj = new Character(luck, strength, height, age, Name);
                return rtnobj;

            }
        }

    }
}

