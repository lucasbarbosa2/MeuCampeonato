using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class TeamService : ITeamService
    {
        private ITeamRepository _teamRepository { get; set; }
        private IMapper _mapper { get; set; }

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TeamsDTO>> Get(int leagueId)
        {
            var teams = await _teamRepository.Get(leagueId);

            var teamsDTO = _mapper.Map<IEnumerable<Team>,IEnumerable<TeamsDTO>>(teams);

            return teamsDTO;
        }
    }
}
