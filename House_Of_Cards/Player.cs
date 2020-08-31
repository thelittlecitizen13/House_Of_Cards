using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
            HandCards = new List<Card>();
        }
        public int Play()
        {
            while (true)
            {
                Console.WriteLine("Hey Player {0}", Name);
                Console.WriteLine();
                Console.WriteLine("Enter 1 to Play Card");
                Console.WriteLine("Enter 2 to Get HINT");
                Console.WriteLine("Enter 3 to Drop Card");
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                    return result;
                else
                    Console.WriteLine("Please enter a number");
            }
        }
        public Card PlayCard()
        {
            Random rnd = new Random(); //might be input also
            if(HandCards!=null)
            {
                Card card = HandCards[rnd.Next(0, HandCards.Count)];
                card.IsExposed = true;
                Console.WriteLine("Player {0} Play the Card {1} Color {2}", Name, card.Number, card.Color);
                HandCards.Remove(card);
                return card;
            }
            return null;
        }
        public void DropCard()
        {
            Random rnd = new Random(); //might be input also
            if (HandCards != null)
            {
                Card card = HandCards[rnd.Next(0, HandCards.Count)];
                Console.WriteLine("Player {0} Drop the Card {1} Color {2}", Name,card.Number,card.Color);
                HandCards.Remove(card);
            }
        }
        
        public void joinGame(GameGroup group)
        {
            System.Console.WriteLine($"Welcome to the game, {Name}!");
            _group = group;
        }
    }
}
