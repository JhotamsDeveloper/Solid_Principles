using Soluction_L.Models;

namespace Soluction_L.Intefaces
{
    public interface IPlayer
    {
        PlayerCategory Category { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        void SetCategory(PlayerCategory category);
    }
}