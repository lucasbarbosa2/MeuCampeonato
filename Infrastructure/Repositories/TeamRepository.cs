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

        public async Task<IEnumerable<Team>> GetTeams(int userId)
        {
            var query = "SELECT * FROM Team where userId = @userId";
            using (var connection = _context.CreateConnection())
            {
                var teams = await connection.QueryAsync<Team>(query, new { userId });
                return teams.ToList();
            }
        }
    }
}
