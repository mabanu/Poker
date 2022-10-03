namespace PokerAPI.Model;

public class Table
{
    public int TableChips { get; set; }
    public List<Card> CardsAtTable = new();
    
    
    public void TableNewHand()
    {
        CardsAtTable.Clear();
        TableChips = 0;
    }

    public void PlaceBet(int bet)
    {
        TableChips += bet;
    }
}