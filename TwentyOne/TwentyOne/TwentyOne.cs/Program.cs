using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random rand = new Random();

            while(deck.Cards.Count > 0)
            {
                int randIndex = rand.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randIndex]);
                deck.Cards.RemoveAt(randIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
