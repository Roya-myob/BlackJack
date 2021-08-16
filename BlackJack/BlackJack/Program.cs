using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            Gambler gambler = new Gambler();
            BlackJackIO blackJackIO = new BlackJackIO();
            BlackJackRules blackJackRules = new BlackJackRules(blackJackIO);
           // Gambler _gambler = new Gambler();
            
            
            var blackJack = new BlackJackEngine(blackJackRules, dealer, gambler);
            
            blackJack.Start();
        }
    }
}