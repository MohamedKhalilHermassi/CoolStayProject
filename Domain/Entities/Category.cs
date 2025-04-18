using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = String.Empty;
        public ICollection<Property> Properties { get; set; } = new List<Property>();

    }
}
