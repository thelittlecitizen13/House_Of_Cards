using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System;
using System.Drawing;

namespace House_Of_Cards
{
    public class HouseOfCards
    {
        public List<Card> AllCards { get; set; }
        public List<Card> CardsPot { get; set; }
        public GameGroup groupOfPlayers { get; set; }
        public int StrikesLeft { get; set; }
        public int HintsLeft { get; set; }
        private List<string> _cardColors;
        

        public HouseOfCards(GameGroup group)
        {
            AllCards = new List<Card>();
            CardsPot = new List<Card>();
            groupOfPlayers = group;
            StrikesLeft = 4;
            HintsLeft = 5;
            _cardColors = new List<string>() { "green", "red", "blue", "yellow", "white" };
        }
        public void GenerateCards()
        {
            // move values like colors, numbers to conf file
            for (int i = 1; i <= 5; i++)
            {
                foreach (var color in _cardColors)
                {
                    AllCards.Add(new Card(i, color));
                }
            }
            CardsPot = new List<Card>(AllCards);
        }
        
        public void AddPlayerToTheGame(Player player)
        {
            if (groupOfPlayers.players.Count >= 4)
            {
                Console.WriteLine("Reached group limit (4)! Cannot add any more players to the game.");
            }
            else
            {
                groupOfPlayers.AddPlayer(player);
                player.joinGame(groupOfPlayers);
            }
        }
    }
}
