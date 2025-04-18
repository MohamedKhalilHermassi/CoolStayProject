using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class ClimateControlAmenities
    {
        [Required]
        public bool AirConditioning { get; set; }
        [Required]
        public bool Heating { get; set; }
        [Required]
        public bool Fans { get; set; }
    }
}
