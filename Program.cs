using System;
namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            var cardDeck = deck.Deal();

            foreach (var card in cardDeck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.Suit}");
            }

            // ** Uncomment and run shuffledDeck then sortedDeck **

            //var shuffledDeck = deck.Shuffle();
            //foreach (var card in shuffledDeck)
            //{
            //    Console.WriteLine($"{card.CardNumber} of {card.Suit}");
            //}

            //sortedDeck = deck.Sort();
            //foreach (var card in sortedDeck)
            //{
            //    Console.WriteLine($"{card.CardNumber} of {card.Suit}");
            //}


            // ** Uncomment and run topCard then sortedDeck **

            //var topCard = deck.DealTopCard();
            //Console.WriteLine($"{topCard.CardNumber} of {topCard.Suit}");

            //var sortedDeck = deck.Sort();
            //foreach (var card in sortedDeck)
            //{
            //    Console.WriteLine($"{card.CardNumber} of {card.Suit}");
            //}
        }
    }
}


