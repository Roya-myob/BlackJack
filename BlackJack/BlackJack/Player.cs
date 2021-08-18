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
        public int GetCardCount();

        public bool IsBlackJacked();

        public void Play(Deck deck);

        public bool IsBusted();

    }
}