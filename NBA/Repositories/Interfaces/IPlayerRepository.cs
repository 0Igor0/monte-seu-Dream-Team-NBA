using NBA.Models;

namespace NBA.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> Players { get; }
        Player GetPlayerById(int playerId);
    }
}
