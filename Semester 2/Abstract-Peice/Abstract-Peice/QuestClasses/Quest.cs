using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Peice
{
    abstract class Quest
    {

        protected string description;
        public Quest(string description)
        {
            this.description = description;
        }
        public abstract void ActiveQuest();
    }
}
