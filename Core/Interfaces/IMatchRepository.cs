using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IMatchRepository
    {
        public Task<IEnumerable<Match>> GetMatches(int userId);
    }
}
