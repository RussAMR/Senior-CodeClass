using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_O_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int usinp;
            Deck mydeck = new Deck();
            do
            {
                Console.WriteLine("***Menu System for deck***");
                Console.WriteLine("***Pick 0 to Exit***");
                Console.WriteLine("***Pick 1 to shuffle your deck***");
                Console.WriteLine("***Pick 2 to show your deck***");
                Console.WriteLine("***Pick 3 to discard a card");
                Console.WriteLine("***Pick 4 to show the discard pile***");
                Console.WriteLine("***Pick 5 to draw a card***");
                usinp = int.Parse(Console.ReadLine());
                if (usinp == 1)
                {
                    mydeck.Shuffle();
                }
                if (usinp == 2)
                {
                    mydeck.PrintDeck();
                }
                if (usinp == 3)
                {                   
                    mydeck.Discard();
                }
                if (usinp == 4)
                {
                    mydeck.PrintDisc();
                }
                if (usinp == 5)
                {
                    mydeck.Draw();
                }
            } while (usinp != 0);
               
        }
    }
}
