using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILeagueRepository
    {
        public Task<IEnumerable<League>> GetUserLeagues(int userId);

        public Task<League> Get(int leagueId);
    }
}
