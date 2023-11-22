using Dapper;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly DapperContext _context;
        public MatchRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Match>> GetMatches(int leagueId) {
            var query = "SELECT * FROM Match where leagueId = @leagueId";
            using (var connection = _context.CreateConnection())
            {
                var matches = await connection.QueryAsync<Match>(query, new { leagueId });
                return matches.ToList();
            }
        }
    }
}
