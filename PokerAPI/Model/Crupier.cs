namespace PokerAPI.Model;

public class Crupier
{
    public List<Card> Deck = new();

    public Crupier()
    {
        for (int i = 1; i < 14; i++)
        {
            Deck.Add(new Card(i, "Hearts", "Red"));
            Deck.Add(new Card(i, "Diamonds", "Red"));
            Deck.Add(new Card(i, "Spades", "Black"));
            Deck.Add(new Card(i, "Clubs", "Black"));
        }
    }
    
    public List<Card> Shuffle()
    {
        // Knuth-Fisher-Yates shuffle card deck algorithm
        var random = new Random();
        for (int i = Deck.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (Deck[i], Deck[j]) = (Deck[j], Deck[i]);
        }
        return Deck;
    }

    public Card GiveCard()
    {
        var card = Deck.Last();
        Deck.Remove(card);
        return card;
    }
}