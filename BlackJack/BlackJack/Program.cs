using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            //Console.WriteLine(card.ShowFace());

            var deck = new Deck();
            deck.BuildDeck();
           // deck.ShowDeck();
            deck.ShuffleDeck();
            //Console.WriteLine(deck.ShowDeck());

            var blackJack = new BlackJack();
            //blackJack.Greeting();
            deck.RemoveCardFromDeckOfCards();
            //deck.ShowDeck();
        }
    }
}