using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class BathroomAmenities
    {
        [Required]
        public bool ToiletPaper { get; set; }
        [Required]
        public bool Soap { get; set; }
        [Required]
        public bool Shampoo { get; set; }
        [Required]
        public bool TowelForEachGuest { get; set; }
        [Required]
        public bool HairDryer { get; set; }
        [Required]
        public bool FirstAidKit { get; set; }

    }
}
