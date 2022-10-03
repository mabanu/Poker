// See https://aka.ms/new-console-template for more information

using PokerAPI.Model;

var payers = new List<Player>()
{
    new Player(100),
    new Player(100),
    new Player(100),
    new Player(100)
};

var game = new Game(payers);

game.Start();
