using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class TechnologyAmenities
    {
        [Required]
        public bool HasWifi { get; set; }
        [Required]
        public bool HasTV { get; set; }
        [Required]
        public bool HasSmartLock { get; set; }
        [Required]
        public bool HasThermostat{ get; set; }
    }
}
