using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }

        [Required]
        public int FirstTeam { get; set; }

        [Required]
        public int SecondTeam { get; set; }

        [Required]
        public Int16 FirstTeamScore { get; set; }

        [Required]
        public Int16 SecondTeamScore { get; set; }

        [Required]
        public int LeagueId { get; set; }
    }
}
