using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Bedroom
    {
        [Required]
        public int BedCount { get; set; }
    }
}
