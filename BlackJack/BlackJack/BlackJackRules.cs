using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJackRules
    {
        
        

        public bool IsBusted(Player player)
        {
            var isBusted = false;
            if (player.ShowCardSum() > 21)
            {
                isBusted = true;
            }

            return isBusted;
        }

        public string Score(Player player, Dealer dealer)
        {
             var playerScore = player.ShowCardSum();
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

             if (dealerScore == 21 & playerScore == 21)
             {
                 winner = "Tie!";
             }

             return winner;
        }
        
        
    }
}