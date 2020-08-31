namespace House_Of_Cards
{
    public class Card
    {
        public int Number { get; set; }
        public string Color { get; set; }
        public bool IsExposed { get; set; }
        public Card(int num, string color)
        {
            Number = num;
            Color = color;
            IsExposed = false;
        }
        public string ExposeCard()
        {
            IsExposed = true;
            return ShowCard();
        }
        public string ShowCard()
        {
            if (IsExposed)
                return $"Color: {Color}, Number: {Number}";
            else
                return "Card didnt expose";
        }
        public string ShowToGroupBuddy()
        {
            return $"Color: {Color}, Number: {Number}";
        }

    }
}
