namespace Problem_L.Models
{
    public class FootballPlayer : Player
    {
        //Traer valor del mercado
        public string GetMarketValue(PlayerCategory category)
        {
            string MarketValue = "";

            switch (category)
            {
                case PlayerCategory.Amateur:
                    MarketValue = "100";
                    break;
                case PlayerCategory.professional:
                    MarketValue = "1000";
                    break;
            }

            return MarketValue;
        }
    }
}
