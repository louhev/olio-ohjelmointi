using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        List<Card> deck;

        //default constructor
        public Deck()
        {
            deck = new List<Card>();
        }

        
        public void AddCard(Card card)
        {
            deck.Add(card);
        }

        public void PrintDeck()
        {
            Console.WriteLine("The current deck:");
            foreach (Card card in deck)
            {
                Console.WriteLine(card.ToString());
            }
        }

        /// <summary>
        /// Shuffles deck
        /// </summary>
        private static Random rng = new Random();
        public void Shuffle()
        {
            Console.WriteLine("Shuffling deck...");

            //Shuffle algorithm from http://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
    }
}
