using System.Collections.Generic;

namespace House_Of_Cards
{
    public class GameTable
    {
        public Dictionary<string, List<Card>> CardsOnTable { get; set; }
        public GameTable()
        {
            CardsOnTable = new Dictionary<string, List<Card>>();
        }
        public bool TryPutCardOnTable(Card card)
        {
            return true;
        }
        public void PrintTable()
        {

        }
    }
}
