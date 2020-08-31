using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System;

namespace House_Of_Cards
{
    public class HouseOfCards
    {
        public List<Card> AllCards { get; set; }
        public List<Card> CardsPot { get; set; }
        public GameGroup groupOfPlayers { get; set; }
        public int StrikesLeft { get; set; }
        public int HintsLeft { get; set; }
        
        

        public HouseOfCards(GameGroup group)
        {
            AllCards = new List<Card>();
            CardsPot = new List<Card>();
            groupOfPlayers = group;
            StrikesLeft = 4;
            HintsLeft = 5;
        }
        public void GenerateCards()
        {

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
