using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class PetFriendlyAmenities
    {
        [Required]
        public bool PetBowls { get; set; }
        [Required]
        public bool PetBed { get; set; }
        
    }
}
