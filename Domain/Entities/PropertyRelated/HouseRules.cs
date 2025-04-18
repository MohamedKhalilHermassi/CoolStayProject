using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class HouseRules
    {
        [Required]
        public bool PetsAllowed { get; set; }
        [Required]
        public bool SmokingAllowed { get; set; }
        [Required]
        public bool PartiesAndEventsAllowed { get; set; }
        [Required]
        public bool UnregisteredGuestsAllowed { get; set; }
        [Required]
        public bool MovingFurniture { get; set; }

    }
}
