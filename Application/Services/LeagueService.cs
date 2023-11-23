using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;
        private readonly IMapper _mapper;

        public LeagueService(ILeagueRepository leagueRepository, IMapper mapper)
        {
            _leagueRepository = leagueRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LeaguesDTO>> Get(int userId)
        {
            var leagues = await _leagueRepository.Get(userId);

            var leaguesDTO = _mapper.Map<IEnumerable<League>, IEnumerable<LeaguesDTO>>(leagues);

            return leaguesDTO;

        }
    }
}
