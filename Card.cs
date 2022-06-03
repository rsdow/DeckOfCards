using System;
namespace DeckOfCards
{
    public class Card
    {
        public Suit Suit { get; set; }
        public CardNumber CardNumber { get; set; }

        public Card(Suit suit, CardNumber cardNumber)
        {
            Suit = suit;
            CardNumber = cardNumber;
        }
    }
}
