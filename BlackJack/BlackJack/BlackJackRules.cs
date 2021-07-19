using System;

namespace BlackJack
{
    public class BlackJackRules
    {
        // if player sum of card = 21  blackjack win - can't be beat
        // if player sum of card > 21 bust - lose the round
        // first is player and once the sum of player is finished, dealer tries to beat the player
        
        // if card 2 to 10 then worth their number
        // if face worth 10
        // if Ace worth 1 or 11
        // first two cards - one card is face then the ace worth 11
        // if sum is 18 then next ace worth 1
        
        // dealer must keep hitting until they get to 17 
        // above 17 they can stay
        
        // if player and dealer blackjack then game is tie
        //if dealer busts then player wins
        // if player bust then dealer wins
        // if  player and dealer both don't bust, whoever closer to 21 wins.
        
        
        
       

        public void Hit()
        {
            
        }

        public void Stand()
        {
            
        }
        
        
        
        
    }
}