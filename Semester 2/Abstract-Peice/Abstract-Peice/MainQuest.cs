using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Peice
{
    class MainQuest : Quest
    {
        public MainQuest(bool isCompleted, bool isHidden, bool isActive, bool isunlocked) : base(isCompleted, isHidden, isActive, isunlocked)
        {
            isCompleted = false;
        }
        public override void Islevellocked()
        {
            base.Islevellocked();
            Console.WriteLine("Has been completed");
        }
    }
}
