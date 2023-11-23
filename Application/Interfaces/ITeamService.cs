using Application.DTO;

namespace Application.Interfaces
{
    public interface ITeamService
    {
        public Task<IEnumerable<TeamsDTO>> Get(int leagueId);
    }
}
