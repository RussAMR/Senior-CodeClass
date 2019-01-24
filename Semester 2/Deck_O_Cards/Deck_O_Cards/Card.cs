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
    class Card
    {

        public Face face;
        public Suit suit;
        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;

        }
        public void Print()
        {
            Console.WriteLine("____________________");
            Console.WriteLine("|" + face + " " + suit + "|");
            Console.WriteLine("____________________");
        }
    }

}
