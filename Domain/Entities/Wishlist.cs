using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Wishlist
    {
        [Required]
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
