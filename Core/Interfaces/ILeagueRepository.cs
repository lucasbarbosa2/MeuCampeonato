using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILeagueRepository
    {
        public Task<IEnumerable<League>> Get(int userId);
    }
}
