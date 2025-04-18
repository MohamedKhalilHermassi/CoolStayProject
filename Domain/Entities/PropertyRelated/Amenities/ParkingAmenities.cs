using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class ParkingAmenities
    {
        [Required]
        public bool ParkingSpot{ get; set; }
        [Required]
        public bool ParkingOnPremises { get; set; }
        [Required]
        public bool ChargingStation { get; set; }
    }
}
