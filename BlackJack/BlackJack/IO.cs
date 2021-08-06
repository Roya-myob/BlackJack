namespace BlackJack
{
    public interface IO
    {
        public void LogCurrentState(Player player);


        public void LogBustState(Player player);


        public void LogHitOrStay(Player player);


        public int LogReadLine(Player player);
    }
}

