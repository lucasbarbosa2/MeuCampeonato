using Application.DTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILeagueService
    {
        public Task<IEnumerable<LeaguesDTO>> GetUserLeagues(int userId);

        public Task<League> Get(int leagueId);
    }
}
