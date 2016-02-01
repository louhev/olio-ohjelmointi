using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();


            for (int i = 0; i <= 3; i++)
            {
                string suit = "";
                if (i == 0) suit = "hearts";
                else if (i == 1) suit = "diamonds";
                else if (i == 2) suit = "clubs";
                else if (i == 3) suit = "spades";

                for (int j = 2; j <= 14; j++)
                {
                    Card card = new Card { Suit = suit, Number = j };
                    deck.AddCard(card);
                }
            }

            deck.PrintDeck();
            deck.Shuffle();
            deck.Shuffle();
            deck.Shuffle();
            deck.PrintDeck();
        }
    }
}
