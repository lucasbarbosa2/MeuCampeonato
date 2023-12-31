﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }

        [Required]
        public int TeamOne{ get; set; }

        [Required]
        public int TeamTwo { get; set; }

        [Required]
        public Int16 TeamOneScore { get; set; }

        [Required]
        public Int16 TeamTwoScore { get; set; }

        public bool IsQuarter { get; set; }

        public bool IsSemi { get; set; }

        public bool IsFinal { get; set; }

        public bool IsThird { get; set; }

        [Required]
        public int LeagueId { get; set; }
    }
}
