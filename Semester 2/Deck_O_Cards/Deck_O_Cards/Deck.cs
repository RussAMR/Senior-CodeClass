using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_O_Cards
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        List<Card> Discard_Pile = new List<Card>();
        public Deck()
        {

            foreach (var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }
        public void Shuffle()
        {
            for (int i = 0; i < deck.Count - 1; i++)
            {
                Random rand = new Random();
                int Rholder = rand.Next(0 - 51);
                Card holder = deck[Rholder];
                deck.RemoveAt(Rholder);
                deck.Add(holder);
                Discard_Pile.Clear();
            }
        }
        public Card Draw()
        {
            if (deck.Count > 0)
            {
                Card myint;
                myint = deck.Last();
                deck.RemoveAt(deck.Count() - 1);
                Console.WriteLine("You drew the");
                myint.Print();
                return myint;
            }
            else
            {
                Console.WriteLine("Stack Underflow (No values left in the list)");
                return deck[0];
            }
        }
        public void Discard()
        {

            Card myhold;
            myhold = deck.Last();
            Discard_Pile.Add(myhold);
            deck.RemoveAt(deck.Count());
        }
        public void PrintDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                deck[i].Print();
            }
        }
        public void PrintDisc()
        {
            for (int i = 0; i < Discard_Pile.Count; i++)
            {

                Discard_Pile[i].Print();
            }
        }


    }

}
