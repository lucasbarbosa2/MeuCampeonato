using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class League
    {
        public int Id { get; set; }

        [Required]
        public string LeagueName { get; set; }

        [Required]
        public int LeagueFirstPlace { get; set; }

        [Required]
        public int LeagueSecondPlace { get; set; }

        [Required]
        public int LeagueThirdPlace {get; set; }

        [Required]
        public int LeagueFourthPlace { get;set; }
    }
}
