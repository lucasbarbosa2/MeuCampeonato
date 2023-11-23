using Dapper;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly DapperContext _context;
        public TeamRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> Get(int leagueId)
        {
            var query = "SELECT t.* FROM " +
                "Team t inner join League l on t.userId = l.userId" +
                " where l.id = @leagueId";
            using (var connection = _context.CreateConnection())
            {
                var teams = await connection.QueryAsync<Team>(query, new { leagueId });
                return teams.ToList();
            }
        }
    }
}
