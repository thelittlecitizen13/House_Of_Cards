using System.Collections.Generic;

namespace House_Of_Cards
{
    public class Player
    {
        private GameGroup _group;
        public string Name { get; set; }
        public List<Card> HandCards { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public int Choose()
        {
            // return choice of act to do
            return 1;
        }
        public void joinGame(GameGroup group)
        {
            System.Console.WriteLine($"Welcome to the game, {Name}!");
            _group = group;
        }
    }
}
