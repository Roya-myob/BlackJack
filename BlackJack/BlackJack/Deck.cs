using System;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization;

namespace BlackJack
{
    public class Deck
    {
        private Card[] _deckOfCards = new Card[52];
        
        static Deck()
        {
            
        }
        public void BuildDeck() 
        {
           // int[] heartCards = new int[]{}; //empty array
           //int[] heartCards = new int[0];   //empty array
           //int[] heartCards = {}            //empty array
           // int[] heartCards = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13};   // creating an array with 13 numbers
           // int [] heartCards = new int[13] // creating an array of 13 integers
           string[] suites = new[] {"heart", "spade", "diamond", "club"};
           var deckPosition = 0;
               for (var suite = 0; suite < 4; suite++)
           {
               for (var card = 0; card < 13; card++)
               {
                   var cards = new Card(suites[suite], card + 1);
                   _deckOfCards[deckPosition++] = cards;
               }
               
           }

        }

        public void ShowDeck()
        {
            foreach(var card in _deckOfCards)
            {
               // Console.WriteLine(card.ShowFace());
                
            }
        }

        public void ShuffleDeck()
        {
            var random = new Random();
           
            int[] unsortedArray= new int[52];
            for (var i=0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = random.Next(0,51);
               
                
            }

            for (var i = 0; i < _deckOfCards.Length; i++ )
            {
                var temp = _deckOfCards[i]; // save the card  
                _deckOfCards[i] = _deckOfCards[unsortedArray[i]]; // replaced the card in the location with the card in the random location 
                _deckOfCards[unsortedArray[i]] = temp; // the random location is replaced with the temp card 
            }

            // _deckOfCards = _deckOfCards.OrderBy(x => random.Next()).ToArray();
            
            foreach (var i in _deckOfCards)
            {
                Console.WriteLine(i.ShowFace());
            }
        }

    }
}