using Soluction_L.Models;

namespace Soluction_L.Intefaces
{
    public interface IPlayerTeam : IPlayer
    {
        public string GetTeam();
        public void AssignTeam(Team team);
    }
}
