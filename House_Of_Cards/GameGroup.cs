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
            players.Add(player);
        }
    }
}
