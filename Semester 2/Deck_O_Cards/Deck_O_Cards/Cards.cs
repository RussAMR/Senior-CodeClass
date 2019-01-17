using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_O_Cards
{
    enum Suit
    {
        Hearts,
        Clubs,
        Spades,
        Diamonds
    }
    enum Face
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        J,
        Q,
        K,
        A
    }
    class Cards
    {

        public Face face;
        public Suit suit;
        public Cards(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
            
        }
        public void Print(Face face, Suit suit)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int d = 0; d < 11; d++)
                    {
                    Console.WriteLine("____________________");
                    Console.WriteLine("|" + Face[d] + Suit[i] + "|");
                    Console.WriteLine("____________________");
                }
            }

        }
    }

}
