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
        private int _currentPlayerIndex;
        

        public HouseOfCards(GameGroup group)
        {
            AllCards = new List<Card>();
            CardsPot = new List<Card>();
            groupOfPlayers = group;
            StrikesLeft = 4;
            HintsLeft = 5;
            
            _currentPlayerIndex = 0;
        }
        public void Run()
        {
            GenerateCards();
        }
        private void GenerateCards()
        {

        }
        private void distributeCards()
        {

        }
        public void NextMove()
        {

        }
        

        private void giveCard(Player player)
        {

        }

        private void getCardFromPlayer(Player player)
        {

        }
        private void HintPlayer(Player player)
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
