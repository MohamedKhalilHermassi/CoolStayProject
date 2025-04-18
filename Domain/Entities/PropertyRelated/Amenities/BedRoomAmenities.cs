using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class BedRoomAmenities
    {
        [Required]
        public bool FreshBedSheets { get; set; }
        [Required]
        public bool ExtraBlankets { get; set; }
        [Required]
        public bool ClothHangers { get; set; }
        [Required]
        public bool Curtains { get; set; }
        [Required]
        public bool AlarmClock { get; set; }
    }
}
