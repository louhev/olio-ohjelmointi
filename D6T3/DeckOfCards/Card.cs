using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Card
    {
        //Suit: hearts + diamonds + clubs + spades
        public string Suit { get; set; }
        //Number: 2-14
        public int Number { get; set; }
        //Number name for 11-14: "Jack" + "Queen" + "King" + "Ace"
        public string NumberName { get; set; }
        

        public override string ToString()
        {
            if (Number <= 10)
            {
                return Number + " of " + Suit;
            }
            else if (Number == 11) NumberName = "Jack";
            else if (Number == 12) NumberName = "Queen";
            else if (Number == 13) NumberName = "King";
            else if (Number == 14) NumberName = "Ace";
            return NumberName + " of " + Suit;
        }
    }
}
