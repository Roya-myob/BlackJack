using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace BlackJack
{
    public class Deck
    {
        //private static Card[] _deckOfCards = new Card[52];
        private List<Card> _deckOfCards = new List<Card> { };


        static Deck()
        {
        }

        public void BuildDeck()
        {
            string[] suites = new[] { "heart", "spade", "diamond", "club" };
            var deckPosition = 0;
            for (var suite = 0; suite < 4; suite++)
            {
                for (var card = 0; card < 13; card++)
                {
                    string[] names = new[]
                        { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Queen", "Jack", "King" };
                    
                    //var cards = new Card(suites[suite], card + 1);
                    var cards = new Card(names[card], suites[suite], Math.Min(card + 1, 10));
                    //_deckOfCards[deckPosition++] = cards;
                    _deckOfCards.Add(cards);
                }
            }
        }

        public void ShowDeck()
        {
            foreach (var card in _deckOfCards)
            {
                Console.WriteLine(" Show Deck   ----  " + card.RevealFace());
            }
        }

        public void ShuffleDeck()
        {
            var random = new Random();

            int[] unsortedArray = new int[52];
            for (var i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0, 51);
            }

            for (var i = 0; i < _deckOfCards.Count; i++)
            {
                var temp = _deckOfCards[i]; // save the card  
                _deckOfCards[i] = _deckOfCards[unsortedArray[i]]; // replaced the card in the location with the card in the random location 
                _deckOfCards[unsortedArray[i]] = temp; // the random location is replaced with the temp card 
            }

            // _deckOfCards = _deckOfCards.OrderBy(x => random.Next()).ToArray();
            
        }

        public Card RemoveCardFromDeckOfCards()
        {
            var cardsremainedInDeck = _deckOfCards.Count();
            var drawnCard = _deckOfCards[cardsremainedInDeck - 1];
            _deckOfCards.RemoveAt(cardsremainedInDeck - 1);
            return drawnCard;
        }
    }
}