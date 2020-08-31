using System;
using System.Collections.Generic;

namespace House_Of_Cards
{
    public class GameGroup
    {
        public List<Player> players { get; set; }
        public GameGroup()
        {
            players = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            if (players.Count >= 4)
            {
                Console.WriteLine("Reached group limit (4)! Cannot add any more players to the game.");
            }
            else
            {
                players.Add(player);
                Console.WriteLine($"Welcome to the game, {player.Name}");
            }
        }
    }
}
