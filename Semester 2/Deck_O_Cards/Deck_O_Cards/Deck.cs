using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_O_Cards
{
    class Deck
    {
        List<Cards> deck = new List<Cards>();
        public Deck()
        {

            foreach (var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Cards((Face)face, (Suit)suit));
                }
            }
        }
        public void Shuffle()
        {
            for (int i = 0; i < deck.Count - 1; i++)
            {
                Random rand = new Random();
                int Rholder = rand.Next(0 - 51);
                Cards holder = deck[Rholder];
                deck.RemoveAt(Rholder);
                deck.Add(holder);
            }
        }
        public Cards Draw()
        {
            if (deck.Count > 0)
            {
                Cards myint;
                myint = deck.Last();
                deck.RemoveAt(deck.Count() - 1);
                return myint;
            }
            else
            {
                Console.WriteLine("Stack Underflow (No values left in the list)");
                return deck[0];
            }
        }
    }

}
