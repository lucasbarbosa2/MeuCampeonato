using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
