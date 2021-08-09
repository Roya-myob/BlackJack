using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlackJack
{
    // class Dealer implements interface User

    public class Dealer : Player
    {
        private List<Card> _dealerCards = new List<Card> { };

        public Dealer()
        {
        }

        public int GetDealersCardCount()
        {
            return _dealerCards.Count;
        }

        public void AddCard(Card card)
        {
            _dealerCards.Add(card);
        }

        public string ShowCard()
        {
            string cardFace = " ";
            foreach (var card in _dealerCards)
            {
                cardFace += card.RevealFace() + " | ";
            }

            return cardFace;
        }

        public string ShowLastCard()
        {
            Card last = _dealerCards[_dealerCards.Count - 1];
            return last.RevealFace();
        }

        public int ShowCardSum()
        {
            int cardValues = 0;
            foreach (var card in _dealerCards)
            {
                cardValues += card.RevealFaceValue();
            }

            return cardValues;
        }

        public bool AceInDealersHand()
        {
            bool _aceInDealersHand = false;
            foreach (var card in _dealerCards)
            {
                if (ShowCard().Contains("Ace"))
                {
                    _aceInDealersHand = true;
                }
            }

            return _aceInDealersHand;
        }

        public int ShowCardSumWithAce()
        {
            int cardValue = ShowCardSum();

            if (AceInDealersHand())
            {
                if (cardValue <= 11)

                {
                    cardValue = cardValue + 10;
                }
            }


            return cardValue;
        }
        public string Name()
        {
            return "Dealer";
        }

        public void DealerPlay(Deck deck)
        {
            Console.WriteLine("- Dealer is at1  " + ShowCardSum() + " \n  with the hand:   ["
                              + ShowCard() + "]");


            while (ShowCardSum() < 17)
            {
                AddCard(deck.RemoveCardFromDeckOfCards());
                Console.WriteLine("- Dealer draws  [" + ShowLastCard() + "]");
                Console.WriteLine("- Dealer is at  " + ShowCardSum() + " \n  with the hand:   ["
                                  + ShowCard() + "]");
            }
        }
    }
}