namespace PokerAPI.Model;

public class Card
{
    public int Number { get; set; }
    public string Kind { get; set; }
    public string Color { get; set; }

    public Card(int number, string kind, string color)
    {
        Number = number;
        Kind = kind;
        Color = color;
    }
}