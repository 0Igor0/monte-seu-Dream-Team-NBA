using NBA.Models;

namespace NBA.Repositories.Interfaces
{
    public interface ITeamRepository
    {
        IEnumerable<Team> Teams { get; }
    }
}
