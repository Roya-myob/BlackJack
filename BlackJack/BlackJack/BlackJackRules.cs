using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackRules
    {
        private IO _blackJackIO;
        public BlackJackRules(IO inputOutput)
        {
            _blackJackIO = inputOutput;
        }

        public void GamblersTurn(Gambler gambler, Deck deck)
        {
            _blackJackIO.LogCurrentState(gambler);
            while (!IsBusted(gambler))
            {
                if (gambler.IsGamblerBlackJacked())
                {
                    Console.WriteLine("Gambler BlackJacked!!");
                    break;
                } 
                
                _blackJackIO.LogHitOrStay(gambler);
               
                var isHitOrStay = _blackJackIO.LogReadLine(gambler);
                if ( isHitOrStay == 1)
                {
                    gambler.AddCard(deck.RemoveCardFromDeckOfCards());

                    if (!IsBusted(gambler))
                    {
                        _blackJackIO.LogCurrentState(gambler);

                    }
                    else
                    {
                        _blackJackIO.LogBustState(gambler);
                    }
                      
                }
                else if ( isHitOrStay == 0)
                {
                    break;
                }
            }
        }

        public bool IsBusted(Gambler gambler)
        {
            var isBusted = false;
            if (gambler.ShowCardSum() > 21)
            {
                isBusted = true;
            }

            return isBusted;
        }
        public void DealerTurn(Gambler gambler, Dealer dealer, Deck deck)
        {
            if (!gambler.IsGamblerBlackJacked() && !IsBusted(gambler))
            {
                dealer.DealerPlay(deck);
                Console.WriteLine(Score(gambler, dealer));
            }
        }

        public string Score(Gambler gambler, Dealer dealer)
        {
            _blackJackIO.LogCurrentState(dealer);
             var playerScore = gambler.ShowCardSum();
             var dealerScore = dealer.ShowCardSum();
             string winner = "";
             
            
             if (playerScore > dealerScore)
             {
                  winner = "Player wins!";
             }
             if (dealerScore > playerScore)
             {
                 winner = "Dealer wins!";
             }
             if ( playerScore == 21)
             {
                 winner = "Player wins! BlackJack!";
             }
             if ( dealerScore == 21)
             {
                 winner = "Dealer wins! BlackJack!";
             }

             if (dealerScore == 21 && playerScore == 21)
             {
                 winner = "Tie!";
             }

             return winner;
        }
        
        
    }
}