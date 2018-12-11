using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character_Creation_Save_Load
{
    class Character
    {
        public int luck;
        public int strength;
        public float height;
        public int age;
        public string Name;
        public Character(int luck = 0, int strength = 0, float height = 0, int age = 0, string Name = "Default")
        {
            this.luck = luck;
            this.strength = strength;
            this.height = height;
            this.age = age;
            this.Name = Name;
        }

    }
}
