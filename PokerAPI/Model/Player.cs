namespace PokerAPI.Model;

public class Player
{
    public int PlayerChips { get; set; }
    public List<Card> Hand = new();

    public Player(int chips)
    {
        PlayerChips = chips;
    }

    public Player(Card card)
    {
        Hand.Add(card);
    }

    public void PlayerNewHand()
    {
        Hand.Clear();
    }
}