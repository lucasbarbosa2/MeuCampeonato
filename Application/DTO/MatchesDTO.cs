﻿namespace Application.DTO
{
    public class MatchesDTO
    {
        public string LeagueName { get; set; }

        public int LeagueId { get; set; }

        public IEnumerable<MatchDTO> Matches { get; set; }
    }

    public class MatchDTO
    {
        public int Id { get; set; }

        public int TeamOne { get; set; }

        public int TeamTwo { get; set; }

        public string TeamOneName { get; set; }

        public string TeamTwoName { get; set; }

        public Int16 TeamOneScore { get; set; }

        public Int16 TeamTwoScore { get; set; }

        public bool IsQuarter { get; set; }

        public bool IsSemi { get; set; }

        public bool IsFinal { get; set; }

        public bool IsThird { get; set; }
    }
}
