using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Peice
{
    class SideQuest : Quest
    {
        protected bool isCompleted;
        protected bool isHidden;
        protected bool isActive;
        protected bool isUnlocked;
        protected int isLevLoc;
        public SideQuest(bool isCompleted, bool isHidden, bool isActive, bool isUnlocked, string description, int isLevLoc) : base(description)
        {
            this.isCompleted = isCompleted;
            this.isHidden = isHidden;
            this.isActive = isActive;
            this.isUnlocked = isUnlocked;
            this.isLevLoc = isLevLoc;
        }
        public override void ActiveQuest()
        {
            if(isHidden == true)
            {
                Console.WriteLine("Completed? "+ isCompleted+ " Do you have it active? "+ isActive+ " is it unlocked? "+ isUnlocked+ " "+ description+ " is it level locked? "+ isLevLoc+ " was it a hidden quest? "+ isHidden+" Your new level is over 9000!!!!! ");
            }       
            else
            {
                Console.WriteLine("Completed? " + isCompleted + " Do you have it active? " + isActive + " is it unlocked? " + isUnlocked + " " + description + " is it level locked? " + isLevLoc + " was it a hidden quest? " + isHidden);
            }              
        }
    }
}
