using System;
using System.Threading.Channels;

namespace BlackJack
{

    public class BlackJackIO : IO
    {
        public void LogCurrentState(Player player)
        {
            Console.WriteLine("- Gambler >> You are currently at " + player.ShowCardSum() + " \n  with the hand: [ " +
                              player.ShowCard() + "]");
            
            
        }
        
        public void LogBustState(Player roya)
        {
            Console.WriteLine("- Gambler >> You are currently at " + roya.ShowCardSum() + " BUST " +
                              " \n  with the hand: [ "
                              + roya.ShowCard() + "]");
            
            
        }

        public void LogHitOrStay(Player player)
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        }
        
        public int LogReadLine(Player roya)
        {
            int hitOrStay = Int32.Parse(Console.ReadLine());
            return hitOrStay;
        }
    }

}