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

        public void GamblersTurn(Player gambler, Deck deck)
        {
            _blackJackIO.LogCurrentState(gambler);
            while (!gambler.IsBusted())
            {
                if (gambler.IsBlackJacked())
                {
                    Console.WriteLine("Gambler BlackJacked!!");
                    break;
                } 
                
                _blackJackIO.LogHitOrStay(gambler);
               
                var isHitOrStay = _blackJackIO.LogReadLine(gambler);
                if ( isHitOrStay == 1)
                {
                    gambler.AddCard(deck.RemoveCardFromDeckOfCards());

                    if (!gambler.IsBusted())
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

        
        public void DealerTurn(Player gambler, Player dealer, Deck deck)
        {
            if (!gambler.IsBlackJacked() && !gambler.IsBusted())
            {
                dealer.Play(deck);
                Console.WriteLine(Score(gambler, dealer));
            }
        }
        

        public string Score(Player gambler, Player dealer)
        {
            _blackJackIO.LogCurrentState(dealer);
             var gamblerScore = gambler.ShowCardSum();
             var dealerScore = dealer.ShowCardSum();
             string winner = "";
             
            
             if (gamblerScore > dealerScore)
             {
                  winner = "Gambler wins!";
             }
             if (dealerScore > gamblerScore)
             {
                 winner = "Dealer wins!";
             }
             if ( gamblerScore == 21)
             {
                 winner = "Gambler wins! BlackJack!";
             }
             if ( dealerScore == 21)
             {
                 winner = "Dealer wins! BlackJack!";
             }

             if (dealerScore == 21 && gamblerScore == 21)
             {
                 winner = "Tie!";
             }

             if (dealerScore > 21 && gamblerScore <= 21)
             {
                 winner = "Gambler winsz!";
             }
             if (dealerScore == gamblerScore)
             {
                 winner = "Gambler winsz!";
             }
             

             return winner;
        }
        
        
    }
}