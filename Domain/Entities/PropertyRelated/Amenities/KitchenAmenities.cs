using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class KitchenAmenities
    {
        [Required]
        public bool Refrigerator { get; set; }
        [Required]
        public bool Microwave { get; set; }
        [Required]
        public bool Stove { get; set; }
        [Required]
        public bool Oven { get; set; }
        [Required]
        public bool Cookware { get; set; }
        [Required]
        public bool CoffeMaker { get; set; }
        [Required]
        public bool Dishwasher { get;set; }
        [Required]
        public bool TrashBin { get; set; }
    }
}
