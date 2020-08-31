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
            if (_game.groupOfPlayers.players.Count < 2 || 4 < _game.groupOfPlayers.players.Count)
            {
                System.Console.WriteLine($"Number of players does not fit to game reqiurements (2-4)! Cannot start the game");
                System.Console.WriteLine($"Current number of players: {_game.groupOfPlayers.players.Count}");
            }
            _game.GenerateCards();
            distributeCards();
            while (_game.CardsPot.Count > 0)
            {
                NextMove();
            }
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
    }
}
