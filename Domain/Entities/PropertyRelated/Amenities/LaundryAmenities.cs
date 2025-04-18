using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class LaundryAmenities
    {
        [Required]
        public bool HasWasher { get; set; }
        [Required]
        public bool LaundryDetergent { get; set; }
        [Required]
        public bool IroningBoard { get; set; }
        [Required]
        public bool DryingRack { get; set; }

    }
}
