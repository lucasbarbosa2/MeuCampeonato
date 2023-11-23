using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;
        
        public MatchService(IMatchRepository matchRepository, IMapper mapper, ITeamService teamService)
        {
            _matchRepository = matchRepository;
            _mapper = mapper;
            _teamService = teamService;
        }

        public async Task<IEnumerable<MatchesDTO>> Get(int leagueId)
        {
            var matches = await _matchRepository.Get(leagueId);

            var matchesDTO = _mapper.Map<IEnumerable<Match>,IEnumerable<MatchesDTO>>(matches);

            var teamsDTO = await _teamService.Get(leagueId);
            
            foreach(var matchDTO in matchesDTO)
            {
                matchDTO.TeamOneName = teamsDTO.FirstOrDefault(f => f.Id == matchDTO.TeamOne)?.Name;
                matchDTO.TeamTwoName = teamsDTO.FirstOrDefault(f => f.Id == matchDTO.TeamTwo)?.Name;
            }

            return matchesDTO;
        }
    }
}
