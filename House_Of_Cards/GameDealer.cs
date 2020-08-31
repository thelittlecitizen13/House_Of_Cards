namespace House_Of_Cards
{
    public class GameDealer
    {
        private HouseOfCards _game;
        public GameDealer()
        {
            _game = new HouseOfCards(new GameGroup());
        }
        public void AddPlayerToTheGame(Player player)
        {
            _game.AddPlayerToTheGame(player);
        }
    }
}
