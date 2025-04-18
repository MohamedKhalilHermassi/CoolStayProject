using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class FamilyFriendltAmenities
    {
        [Required]
        public bool BabyBath { get; set; }
        [Required]
        public bool KidsBooksAndToys { get; set; }
        
    }
}
