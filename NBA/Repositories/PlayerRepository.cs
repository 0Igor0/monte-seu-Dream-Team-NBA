using Microsoft.EntityFrameworkCore;
using NBA.Context;
using NBA.Models;
using NBA.Repositories.Interfaces;

namespace NBA.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly AppDbContext _context;
        public PlayerRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Player> Players => _context.Players.Include(c => c.Team);

        public Player GetPlayerById(int playerID)
        {
            return _context.Players.FirstOrDefault(l => l.PlayerID == playerID);
        }
    }
}
