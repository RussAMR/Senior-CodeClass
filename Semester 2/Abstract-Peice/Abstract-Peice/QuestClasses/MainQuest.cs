using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Peice
{
    class MainQuest : Quest
    {
        protected bool isCompleted;
        protected bool isActive;
        protected bool isUnlocked;
        public MainQuest(bool isCompleted, bool isActive, bool isUnlocked, string description) : base(description)
        {
            this.isCompleted = isCompleted;
            this.isActive = isActive;
            this.isUnlocked = isUnlocked;
        }
        public override void ActiveQuest()
        {
            Console.WriteLine("Completed? "+ isCompleted+ " Do you have it active? " + isActive + " is it unlocked? "+ isUnlocked+" "+description);
        }

    }
}
