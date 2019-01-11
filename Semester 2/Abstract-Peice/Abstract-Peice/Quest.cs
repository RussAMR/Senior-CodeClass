using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Peice
{
    abstract class Quest
    {
        protected bool isCompleted;
        protected bool isHidden;
        protected bool isActive;
        protected bool isunlocked;
        protected bool isLevel_Locked;
        public Quest(bool isCompleted, bool isHidden, bool isActive, bool isunlocked)
        {
            this.isActive = isActive;
            this.isHidden = isHidden;
            this.isunlocked = isunlocked;
            this.isCompleted = isCompleted;
        }
        public virtual void Islevellocked()
        {
            Console.WriteLine("Level-Locked");
        }
    }
}
