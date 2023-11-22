using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITeamRepository
    {
        public Task<IEnumerable<Team>> GetTeams(int leagueId);
    }
}
