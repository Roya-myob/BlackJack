using System;

namespace BlackJack
{
    public class JayIO: IO
    {
        public void LogCurrentState(Player player)
        {
            Console.WriteLine("Jay Current State " + player.ShowCard());
        }

        public void LogBustState(Player player)
        {
            Console.WriteLine("Oohhh Noooo you loser! " + player.ShowCard());
        }

        public void LogHitOrStay(Player player)
        {
            Console.WriteLine(" 1 = hit or 2 = stand");
        }

        public int LogReadLine(Player player)
        {
            int hitOrStay = Int32.Parse(Console.ReadLine());
            Console.WriteLine("JayIO");
            return hitOrStay;
        }
    }
}