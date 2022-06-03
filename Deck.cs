using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            Deal();
        }

        public List<Card> Deal()
        {
            CardNumber num;
            Suit suit;

            for (int i = 1; i <= 13; i++)
            {
                num = (CardNumber)i;

                for (int j = 1; j <= 4; j++)
                {
                    suit = (Suit)j;
                    Cards.Add(new Card(suit, num));
                }
            }

            return Cards.ToList();
        }

        public List<Card> Shuffle()
        {
            var rand = new Random();
            List<Card> shuffledDeck = Cards.OrderBy(item => rand.Next()).ToList();

            return shuffledDeck;
        }

        public List<Card> Sort()
        {
            List<Card> sortedDeck = Cards.OrderBy(Suit => Suit.Suit).ThenBy(CardNumber => CardNumber.CardNumber).ToList();
            return sortedDeck;
        }

        public Card DealTopCard()
        {
            Card card;
            // assumption made - deck of cards is placed face down before removing the top card
            card = Cards.LastOrDefault();
            Cards.Remove(card);

            return card;
        }
    }
}