using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // var card = new Card("Ace", 1);
            //Console.WriteLine(card.ShowFace());

            var deck = new Deck();
            deck.BuildDeck();
            deck.ShowDeck();
            deck.ShuffleDeck();
            //Console.WriteLine(deck.ShowDeck());
        }
    }
}