using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Watergun
{
    class Watergun
    {
        float amount = 1f;
        Random rand = new Random();
        bool iswet = false;
        public Watergun()
        {

        }

        public bool shoot(float capacity)
        {
            
            if (capacity > 0)
            {
                capacity -= amount;
                float percentchance = (amount * .2f) + .2f;
                if (rand.NextDouble() < percentchance)
                {
                    iswet = true;
                }
                else
                {
                    iswet = false;
                }
            }
            else
            {
                Console.WriteLine("You're out of ammo you must reload");
            }
            return false;
        }
        public bool refill(float capacity)
        {
          capacity =  capacity + .25f;
            return false;
        }
    }
}
