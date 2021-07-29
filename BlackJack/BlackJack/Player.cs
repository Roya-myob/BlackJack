using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Player
    {
        private List<Card> _playerCards = new List<Card> { };


        public Player()
        {
        }

        public int GetPlayersCardCount()
        {
            return _playerCards.Count;
        }

      
        
        // it's a better practise to have a method for each operation instead of getter and setter
        // This way, we don't expose player implementation for adding to  _playerCards 
        // So instead of  player.PlayerCards.Add(deck.RemoveCardFromDeckOfCards());
        // We have        player.AddCard(deck.RemoveCardFromDeckOfCards());
        
        /*public List<Card> PlayerCards
        {
            set { _playerCards = value; }
            get { return _playerCards; }
        }*/
        
        // command
        public void AddCard(Card card)
        {
            _playerCards.Add(card);
           
        }
        //query
        public string ShowCard()
        {
            string cardValues = " ";
            foreach (var card in _playerCards)
            {
                cardValues += card.RevealFace() + " | ";

            }

            return cardValues;
        }
        
        public int ShowCardSum()
        {
            int cardValues = 0;
            foreach (var card in _playerCards)
            {
                cardValues += card.RevealFaceValue();

            }

            return cardValues;
        }
       
        
        
        
    }
}