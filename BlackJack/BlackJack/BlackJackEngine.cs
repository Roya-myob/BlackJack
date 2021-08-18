using System;
using System.Threading;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackEngine
    {
        private Dealer _dealer;
        private Gambler _gambler;
        private BlackJackRules _blackJackRules;
        private Deck deck = new Deck();

        public BlackJackEngine(
            BlackJackRules rule,
            Dealer dealer,
            Gambler gambler
        )
        {
            _blackJackRules = rule;
            _dealer = dealer;
            _gambler = gambler;
        }

        public void Start()
        {
            InitiateDeck();
            Deal();
            Play();
        }

        private void InitiateDeck()
        {
            deck.BuildDeck();
            deck.ShuffleDeck();
        }

        private void Deal()
        {
            while (_gambler.GetCardCount() < 2)
            {
                _gambler.AddCard(deck.RemoveCardFromDeckOfCards());
                _dealer.AddCard(deck.RemoveCardFromDeckOfCards());
               
            }

        }

        private void Play() 
        {
            _blackJackRules.GamblersTurn(_gambler, deck);
             _blackJackRules.DealerTurn(_gambler, _dealer, deck);

        }
    }
}