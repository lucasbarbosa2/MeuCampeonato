using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class League
    {
        public int Id { get; set; }
        
        public bool Finished { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int FirstPlace { get; set; }

        [Required]
        public int SecondPlace { get; set; }

        [Required]
        public int ThirdPlace {get; set; }

        [Required]
        public int FourthPlace { get;set; }

        [Required]
        public int UserId { get; set; }
    }
}
