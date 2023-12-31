﻿using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<League, LeaguesDTO>().ReverseMap();
            CreateMap<Match, MatchDTO>().ReverseMap();
            CreateMap<Team, TeamsDTO>().ReverseMap();            
        }
    }
}
