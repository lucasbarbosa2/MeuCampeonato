using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMatchRepository
    {
        public Task<IEnumerable<Match>> Get(int leagueId);
    }
}
