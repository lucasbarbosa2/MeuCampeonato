using Application.DTO;

namespace Application.Interfaces
{
    public interface ILeagueService
    {
        public Task<IEnumerable<LeaguesDTO>> Get(int userId);
    }
}
