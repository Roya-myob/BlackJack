using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlackJack
{
    public class Dealer
    {
        
        private List<Card> _dealerCards = new List<Card>{};

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
            string cardValues = " ";
            foreach (var card in _dealerCards)
            {
                cardValues += card.RevealFace() + " | ";

            }

            return cardValues;
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
        
        public void DealerPlay( Deck deck)
        {
            
                Console.WriteLine("- Dealer is at  " + ShowCardSum() + " \n  with the hand:   ["
                                  + ShowCard() + "]");

                // success: 1, 2, 3... 15, 16
                // fail: 17, 18... 21, 22... inf
                while (ShowCardSum() < 17)
                {
                    AddCard(deck.RemoveCardFromDeckOfCards());
                    Console.WriteLine("- Dealer draws  [" + ShowLastCard() + "]");
                    Console.WriteLine("- Dealer is at  " + ShowCardSum() + " \n  with the hand:   ["
                                      + ShowCard() + "]");

                    // success: 22, 23, ... inf
                    /*if (dealer.ShowCardSum() > 21)
                    {
                        break;
                    }*/
                }

                

                
        }
    }
}