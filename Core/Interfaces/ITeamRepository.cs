using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITeamRepository
    {
        public Task<IEnumerable<Team>> Get(int leagueId);
    }
}
