using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System;
using System.Drawing;

namespace House_Of_Cards
{
    public class HouseOfCards
    {
        public List<Card> AllCards { get; set; }
        public List<List<Card>> CardsPot { get; set; }
        public GameGroup GroupOfPlayers { get; set; }
        public int StrikesLeft { get; set; }
        public int HintsLeft { get; set; }
        private List<string> _cardColors;
        

        public HouseOfCards(GameGroup group)
        {
            AllCards = new List<Card>();
            CardsPot = new List<List<Card>>(); //refactor
            CardsPot.Add(new List<Card>());
            CardsPot.Add(new List<Card>());
            CardsPot.Add(new List<Card>());
            CardsPot.Add(new List<Card>());
            CardsPot.Add(new List<Card>());
            GroupOfPlayers = group;
            StrikesLeft = 4;
            HintsLeft = 5;
            _cardColors = new List<string>() { "green", "red", "blue", "yellow", "white" };
        }
        public void GenerateCards()
        {//refactor
            for (int i = 0; i < 5; i++)
            {
                AllCards.Add(new Card(1, _cardColors[i]));
                AllCards.Add(new Card(1, _cardColors[i]));
                AllCards.Add(new Card(1, _cardColors[i]));
                AllCards.Add(new Card(2, _cardColors[i]));
                AllCards.Add(new Card(2, _cardColors[i]));
                AllCards.Add(new Card(3, _cardColors[i]));
                AllCards.Add(new Card(3, _cardColors[i]));
                AllCards.Add(new Card(4, _cardColors[i]));
                AllCards.Add(new Card(4, _cardColors[i]));
                AllCards.Add(new Card(5, _cardColors[i]));

            }
        }
        
        public void AddPlayerToTheGame(Player player)
        {
            if (GroupOfPlayers.players.Count >= 4)
            {
                Console.WriteLine("Reached group limit (4)! Cannot add any more players to the game.");
            }
            else
            {
                GroupOfPlayers.AddPlayer(player);
                player.joinGame(GroupOfPlayers);
            }
        }
    }
}
