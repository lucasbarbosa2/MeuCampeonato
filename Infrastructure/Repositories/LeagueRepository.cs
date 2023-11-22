using Dapper;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly DapperContext _context;
        public LeagueRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<League>> GetLeagues(int userId)
        {
            var query = "SELECT * FROM League where userId = @userId";
            using (var connection = _context.CreateConnection())
            {
                var leagues = await connection.QueryAsync<League>(query, new { userId });
                return leagues.ToList();
            }
        }
    }
}
