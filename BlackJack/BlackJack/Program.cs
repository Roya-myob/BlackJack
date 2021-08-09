using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackJackIO = new BlackJackIO();
            var blackJack = new BlackJackEngine(new BlackJackRules(blackJackIO));
            blackJack.Start();
           
           
        }
    }
}