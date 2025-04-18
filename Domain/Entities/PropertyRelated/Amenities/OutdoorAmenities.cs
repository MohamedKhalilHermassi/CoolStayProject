using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class OutdoorAmenities
    {
        [Required]
        public bool Balcony { get; set; }
        [Required]
        public bool OutdoorFurniture { get; set; }
        [Required]
        public bool BBQ { get; set; }
        [Required]
        public bool GardenOrBackyard{ get; set; }
        [Required]
        public bool SwimmingPool { get; set; }
        [Required]
        public bool HotTub { get; set; }
    }
}
