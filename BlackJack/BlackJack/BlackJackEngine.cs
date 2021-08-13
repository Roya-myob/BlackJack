using System;
using System.Threading;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackEngine
    {
        //private Gambler _gambler = new Gambler();
        //private Dealer dealer = new Dealer();
        private BlackJackRules _blackJackRules;
        private Deck deck = new Deck();

        public BlackJackEngine(BlackJackRules rule)
        {
            _blackJackRules = rule;
        }

        public void Start(Player dealer, Player gambler)
        {
            InitiateDeck();
            Deal( dealer, gambler);
            Play(gambler, dealer);
        }

        private void InitiateDeck()
        {
            deck.BuildDeck();
            deck.ShuffleDeck();
        }

        private void Deal(Player dealer, Player gambler)
        {
            while (gambler.GetCardCount() < 2)
            {
                gambler.AddCard(deck.RemoveCardFromDeckOfCards());
                dealer.AddCard(deck.RemoveCardFromDeckOfCards());
               
            }

        }

        private void Play(Player gambler, Player dealer) 
        {
            _blackJackRules.GamblersTurn(gambler, deck);
             _blackJackRules.DealerTurn(gambler, dealer, deck);

        }
    }
}