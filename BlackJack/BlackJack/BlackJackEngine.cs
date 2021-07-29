using System;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackEngine
    {
        private Player player = new Player();
        private Dealer dealer = new Dealer();
        private BlackJackRules _blackJackRules = new BlackJackRules();
        private Deck deck = new Deck();


        public void Play()
        {
            deck.BuildDeck();
            deck.ShuffleDeck();
            // deck.ShowDeck();
            Deal();
        }


        public void Deal()
        {
            while (player.GetPlayersCardCount() < 2)
            {
                player.AddCard(deck.RemoveCardFromDeckOfCards());
                dealer.AddCard(deck.RemoveCardFromDeckOfCards());
            }

            Console.WriteLine("- Player >> You are currently at " + player.ShowCardSum() + " \n  with the hand: [ " +
                              player.ShowCard() + "]");

            while (!_blackJackRules.IsBusted(player))
            {
                Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
                int hitOrStay = Int32.Parse(Console.ReadLine());
                if (hitOrStay == 1)
                {
                    player.AddCard(deck.RemoveCardFromDeckOfCards());

                    if (!_blackJackRules.IsBusted(player))
                    {
                        Console.WriteLine("- Player >> You are currently at  " + player.ShowCardSum() +
                                          " \n  with the hand: [ "
                                          + player.ShowCard() + "]");
                    }
                    else
                    {
                        Console.WriteLine("- Player >> You are currently at " + player.ShowCardSum() + " BUST " +
                                          " \n  with the hand: [ "
                                          + player.ShowCard() + "]");
                        Console.WriteLine("Dealer wins!");
                    }
                }
                else if (hitOrStay == 0)
                {
                    break;
                }
            }

            if (!_blackJackRules.IsBusted(player))
            {
                dealer.DealerPlay(dealer,deck);
                Console.WriteLine(_blackJackRules.Score(player,dealer));
                
            }

            
        }
        
    }
}