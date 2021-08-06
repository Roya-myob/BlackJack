using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Gambler : Player
    {
        private List<Card> _gamblerCards = new List<Card> { };

        public int GetGamblersCardCount()
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
            string cardValues = " ";
            foreach (var card in _gamblerCards)
            {
                cardValues += card.RevealFace() + " | ";
            }

            return cardValues;
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

        public bool IsGamblerBlackJacked()
        {
            var winner = false;
            if (ShowCardSum() == 21)
            {
                winner = true;
            }

            return winner;
        }
    }
}