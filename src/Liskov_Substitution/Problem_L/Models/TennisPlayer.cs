namespace Problem_L.Models
{
    public class TennisPlayer : Player
    {
        public override void AssignTeam(Team team)
        {
            throw new NotImplementedException("Soy un jugador de tenis y no necesito un equipo para jugar");
        }
    }
}
