using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            Gambler gambler = new Gambler();
           // Gambler _gambler = new Gambler();
            
            var blackJackIO = new BlackJackIO();
            var blackJack = new BlackJackEngine(new BlackJackRules(blackJackIO));
            
            blackJack.Start(dealer, gambler);
        }
    }
}