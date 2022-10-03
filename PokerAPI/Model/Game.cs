namespace PokerAPI.Model;

public class Game
{
    public List<Player> NumberOfPlayers { get; set; }
    
    public Game(List<Player> players)
    {
        NumberOfPlayers = players;
    }
    
    public void Start()
    {
        var crupier = new Crupier();
        crupier.Shuffle();

        var table = new Table();

        while (crupier.Deck.Count > 52 - NumberOfPlayers.Count * 2 + 5)
        {
            foreach (var player in NumberOfPlayers)
            {
                player.Hand.Add(crupier.GiveCard());
                player.Hand.Add(crupier.GiveCard());
            }
            
            table.CardsAtTable.Add(crupier.GiveCard());
            table.CardsAtTable.Add(crupier.GiveCard());
            table.CardsAtTable.Add(crupier.GiveCard());
            table.CardsAtTable.Add(crupier.GiveCard());
            table.CardsAtTable.Add(crupier.GiveCard());
        }
        
        Console.WriteLine("\ntable");
        foreach (var card in table.CardsAtTable)
        {
            Console.WriteLine($"{card.Number} {card.Kind} {card.Color}");
        }
        

        foreach (var player in NumberOfPlayers)
        {
            Console.WriteLine("\nplayer");
            foreach (var card in player.Hand)
            {
                Console.WriteLine($"{card.Number} {card.Kind} {card.Color}");
            }
        }
    }
}