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
        private readonly ILeagueService _leagueService;
        private readonly IMapper _mapper;
        
        public MatchService(IMatchRepository matchRepository, IMapper mapper, ITeamService teamService, ILeagueService leagueService)
        {
            _matchRepository = matchRepository;
            _mapper = mapper;
            _teamService = teamService;
            _leagueService = leagueService;
        }

        public async Task<MatchesDTO> Get(int leagueId)
        {
            var matches = await _matchRepository.Get(leagueId);

            var matchDTO = _mapper.Map<IEnumerable<Match>, IEnumerable<MatchDTO>>(matches);

            var teamsDTO = await _teamService.Get(leagueId);

            var league = await _leagueService.Get(leagueId);

            var matchesDTO = new MatchesDTO
            {
                LeagueName = league.Name,
                LeagueId = leagueId,
                Matches = matchDTO
            };
            
            foreach(var match in matchDTO)
            {
                match.TeamOneName = teamsDTO.FirstOrDefault(f => f.Id == match.TeamOne)?.Name;
                match.TeamTwoName = teamsDTO.FirstOrDefault(f => f.Id == match.TeamTwo)?.Name;
            }

            return matchesDTO;
        }
    }
}
