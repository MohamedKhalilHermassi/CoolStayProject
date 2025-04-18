using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class Amenities
    {
        [Required]
        public BathroomAmenities BathroomAmenities { get; set; } = new BathroomAmenities();
        [Required]
        public BedRoomAmenities BedRoomAmenities { get; set; } = new BedRoomAmenities();
        [Required]
        public ClimateControlAmenities ClimateControlAmenities { get; set; } = new ClimateControlAmenities();
        [Required]
        public FamilyFriendltAmenities FamilyFriendltAmenities { get; set; } = new FamilyFriendltAmenities();
        [Required]
        public KitchenAmenities KitchenAmenities { get; set; } = new KitchenAmenities();
        [Required]
        public LaundryAmenities LaundryAmenities { get; set; } = new LaundryAmenities();
        [Required]
        public OutdoorAmenities OutdoorAmenities { get; set; } = new OutdoorAmenities();
        [Required]
        public ParkingAmenities ParkingAmenities { get; set; } = new ParkingAmenities();
        [Required]
        public PetFriendlyAmenities PetFriendlyAmenities { get; set; } = new PetFriendlyAmenities();
        [Required]
        public TechnologyAmenities TechnologyAmenities { get; set; } = new TechnologyAmenities();
    }
}
