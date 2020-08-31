using System.Collections.Generic;

namespace House_Of_Cards
{
    public class Player
    {
        private GameGroup _group;
        public string Name { get; set; }
        public List<Card> HandCards { get; set; }

        public Player(string name, GameGroup group)
        {
            Name = name;
            _group = group;
        }

        public int Choose()
        {
            // return choice of act to do
            return 1;
        }
        private void addToGroup()
        {
            // add player to group
        }
    }
}
