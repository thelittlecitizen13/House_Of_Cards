using System;
using System.ComponentModel;

namespace House_Of_Cards
{
    public class GameDealer
    {
        private HouseOfCards _game;
        private int _currentPlayerIndex;
        public GameDealer()
        {
            _game = new HouseOfCards(new GameGroup());
            _currentPlayerIndex = 0;
        }
        public void AddPlayerToTheGame(Player player)
        {
            _game.AddPlayerToTheGame(player);
        }
        public void Run()
        {
            if (_game.GroupOfPlayers.players.Count < 2 || 4 < _game.GroupOfPlayers.players.Count)
            {
                System.Console.WriteLine($"Number of players does not fit to game reqiurements (2-4)! Cannot start the game");
                System.Console.WriteLine($"Current number of players: {_game.GroupOfPlayers.players.Count}");
            }
            _game.GenerateCards();
            distributeCards();
            while (_game.AllCards.Count >= _game.GroupOfPlayers.players.Count)
            {
                foreach (var player in _game.GroupOfPlayers.players)
                {
                    switch (player.Play())
                    {
                        case 1: PlayACard(player); break;
                        case 2: HintPlayer(player); break;
                        case 3: getCardFromPlayer(player); break;
                        default: break;
                    }
                    
                }
            }
            foreach (var cardslist in _game.CardsPot)
            {
                cardslist.
            }
            Console.WriteLine("Game Ended with Score : {0}", );
        }
        public bool IsExistInCardsPot(Card card)
        {
            foreach (var cards in _game.CardsPot)
            {
                if (cards.Contains(card)) return true;
            }
            return false;
        }
        public void PlayACard(Player player)
        {
            Card playercard = player.PlayCard();
            giveCard(player);
            if (IsExistInCardsPot(playercard))
            {
                _game.StrikesLeft--;
                return;
            }

            if (playercard.Number == 1)
            {
                foreach (var cardslist in _game.CardsPot)
                {
                    if (cardslist == null) cardslist.Add(playercard);
                }
            }
            else
            {
                bool isadded = false;
                foreach (var cardslist in _game.CardsPot)
                {
                    foreach (var card in cardslist)
                    {
                        if (card.Color == playercard.Color && card.Number + 1 == playercard.Number)
                        {
                            cardslist.Add(playercard);
                            isadded = true;
                        }
                    }
                }
                if(!isadded) { _game.StrikesLeft--; }


            }
        }
        private void distributeCards()
        {
            foreach (var player in _game.GroupOfPlayers.players)
            {
                for (int i = 0; i < 5; i++)
                {
                    giveCard(player);
                }
            }
        }
        public void NextMove()
        {
            
        }


        private void giveCard(Player player)
        {
            Random rnd = new Random();
            Card card = _game.AllCards[rnd.Next(0, _game.AllCards.Count)];
            _game.AllCards.Remove(card);
            player.HandCards.Add(card);
        }

        private void getCardFromPlayer(Player player)
        {
            player.DropCard();
            giveCard(player);
            if (_game.HintsLeft < 5)
                _game.HintsLeft++;
        }
        private void HintPlayer(Player player)
        {
            Random rnd = new Random();
            player.HandCards[rnd.Next(0, player.HandCards.Count)].IsExposed = true;
        }
    }
}
