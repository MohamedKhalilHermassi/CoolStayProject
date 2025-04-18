using Domain.Entities.PropertyRelated;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Property
    {
        [Key]
        public Guid PropertyId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]  
        public Address Address{ get; set; } = new Address();
        [Required]
        public int BedroomCount { get; set; }
        [Required]
        public int BathroomCount { get; set; }
        [Required]
        public int PricePerNight { get; set; }
        [Required]
        public int MaxGuestsAllowed { get; set; }
        [Required]
        public int CleaningFee { get; set; }
        [Required]
        public DateTime CheckInTime { get; set; }
        [Required]
        public DateTime CheckOutTime { get; set; }
        [Required]
        public float AvgRating { get; set; }
        [Required]
        public int TotalNumberOfRatings { get; set; }
        [Required]
        public ICollection<Bedroom> Bedrooms { get; set; } = new List<Bedroom>();

        [Required]
        public HouseRules HouseRules{ get; set; } = new HouseRules();
        [Required]
        public Amenities Amenities { get; set; } = new Amenities();
    }
}
