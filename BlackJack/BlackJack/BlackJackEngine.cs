using System;
using System.Threading;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackEngine
    {
        private Gambler _gambler = new Gambler();
        private Dealer dealer = new Dealer();
        private BlackJackRules _blackJackRules;
        private Deck deck = new Deck();

        public BlackJackEngine(BlackJackRules rule)
        {
            _blackJackRules = rule;
        }

        public void Play()
        {
            InitiateDeck();
            Deal();
            Start();
        }

        private void InitiateDeck()
        {
            deck.BuildDeck();
            deck.ShuffleDeck();
        }

        private void Deal()
        {
            while (_gambler.GetGamblersCardCount() < 2)
            {
                _gambler.AddCard(deck.RemoveCardFromDeckOfCards());
                dealer.AddCard(deck.RemoveCardFromDeckOfCards());
            }
        }

        private void Start()
        {
            _blackJackRules.GamblersTurn(_gambler, deck);
             _blackJackRules.DealerTurn(_gambler, dealer, deck);

        }
    }
}