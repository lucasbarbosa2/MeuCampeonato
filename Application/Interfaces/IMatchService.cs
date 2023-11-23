using Application.DTO;

namespace Application.Interfaces
{
    public interface IMatchService
    {
        public Task<IEnumerable<MatchesDTO>> Get(int leagueId);
    }
}
