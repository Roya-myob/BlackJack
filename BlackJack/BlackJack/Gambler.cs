using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace BlackJack
{
    public class Gambler : Player
    {
        private List<Card> _gamblerCards = new List<Card> { };

        public int GetCardCount()
        {
            return _gamblerCards.Count;
        }

        // command
        public void AddCard(Card card)
        {
            _gamblerCards.Add(card);
        }

        //query
        public string ShowCard()
        {
            string cardFace = " ";
            foreach (var card in _gamblerCards)
            {
                cardFace += card.RevealFace() + " | ";
            }

            return cardFace;
        }

        public bool AceInGamblersHand()
        {
            bool _aceInGamblesHand = false;
            foreach (var card in _gamblerCards)
            {
                if (ShowCard().Contains("Ace"))
                {
                    _aceInGamblesHand = true;
                }
            }

            return _aceInGamblesHand;
        }
        

        public int ShowCardSum()
        {
            int cardValues = 0;
            foreach (var card in _gamblerCards)
            {
                cardValues += card.RevealFaceValue();
            }

            return cardValues;
        }

        public int ShowCardSumWithAce()
        {
            int cardValue = ShowCardSum();

            if (AceInGamblersHand())
            {
                if (cardValue <= 11)
                {
                    // SetAceToValue11();
                    cardValue = cardValue + 10;
                }
            }


            return cardValue;
        }

        public string Name()
        {
            return "Gambler";
        }
        
        public bool IsBusted()
        {
            var isBusted = false;
            if (ShowCardSum() > 21)
            {
                isBusted = true;
            }

            return isBusted;
        }
        
        public bool IsBlackJacked()
        {
            var winner = false;
            if (ShowCardSum() == 21)
            {
                winner = true;
            }

            return winner;
        }

        public void Play(Deck deck)
        {
            
        }
    }
}