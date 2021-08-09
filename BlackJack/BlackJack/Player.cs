namespace BlackJack
{
    // interface declaration
    public interface Player
    {
        public void AddCard(Card card); 
        public string ShowCard();
        public int ShowCardSum();
        public int ShowCardSumWithAce();
        public string Name();

    }
}