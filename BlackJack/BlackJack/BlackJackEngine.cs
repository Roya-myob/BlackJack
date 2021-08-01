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
            player.PlayerPlay(deck, _blackJackRules, player);

            if (!player.IsPlayerBlackJacked())
            {
                if (!_blackJackRules.IsBusted(player))
                {
                    dealer.DealerPlay(deck);
                    Console.WriteLine(_blackJackRules.Score(player,dealer));
                
                }
            }
            
        }
        
    }
}