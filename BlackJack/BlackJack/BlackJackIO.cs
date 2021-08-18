﻿using System;
using System.Threading.Channels;

namespace BlackJack
{

    public class BlackJackIO : IO
    {
        public void LogCurrentState(Player player)
        {
            Console.WriteLine("- " + player.Name() + " >> You are currently at " + player.ShowCardSumWithAce() + " \n  with the hand: [ " +
                              player.ShowCard() + "]");
            


        }
        
        public void LogBustState(Player player)
        {
            Console.WriteLine("- " + player.Name() + " >> You are currently at " + player.ShowCardSumWithAce() + " BUST " +
                              " \n  with the hand: [ "
                              + player.ShowCard() + "]");
            
            
        }

        public void LogHitOrStay(Player player)
        {
            Console.WriteLine("Hit or stay? (Hit = 1, Stay = 0)");
        }

        public bool MyFunc()
        {
            return true;
        }
        
        public int LogReadLine(Player player)
        {

            while (true)
            {
                try
                {
                    int hitOrStay = Int32.Parse(Console.ReadLine());
                    return hitOrStay;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Exception caught: {e.Message}\n" + "Try again! Hit or stay? (Hit = 1, Stay = 0)");
                
                }
            }

        }
    }

}