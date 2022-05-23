using Soluction_L.Intefaces;

namespace Soluction_L.Models
{
    public class FootballPlayer : Player, IPlayerTeam
    {
        private Team Team { get; set; }
        
        public virtual void AssignTeam(Team team) => Team = team;
        public string GetTeam() => Team.Name;
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
