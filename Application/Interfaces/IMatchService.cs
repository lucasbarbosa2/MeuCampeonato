using Application.DTO;

namespace Application.Interfaces
{
    public interface IMatchService
    {
        public Task<MatchesDTO> Get(int leagueId);
    }
}
