using NBA.Context;
using NBA.Models;
using NBA.Repositories.Interfaces;

namespace NBA.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _context;

        public TeamRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Team> Teams => _context.Teams;
    }
}
