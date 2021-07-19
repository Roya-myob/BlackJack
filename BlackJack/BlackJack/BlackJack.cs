using System;
using System.Threading.Channels;

namespace BlackJack
{
    public class BlackJack
    { 
       private Player player = new Player(); 
       private Dealer dealer = new Dealer(); 
       private  Deck deck = new Deck();
        //private BlackJackEngine _blackJackEngine = new BlackJackEngine();

        public void Greeting()
        {
            Console.WriteLine("Ready to play BlackJack? Type yes to play!");
            var play = Console.ReadLine();
            if (play.Contains("yes"))
            {
                Console.WriteLine(" --- Game Started --- ");
                
                
                
            }else Console.WriteLine("Bye!");
        }

        public void Deal()
        {
                
        }
        


    }
}