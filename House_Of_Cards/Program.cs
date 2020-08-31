using System;
using System.Collections.Generic;

namespace House_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class GameTable
    {
        public Dictionary<string, List<Card>> CardsOnTable { get; set; }
        public GameTable()
        {
            CardsOnTable = new Dictionary<string, List<Card>>();
        }
    }
}
