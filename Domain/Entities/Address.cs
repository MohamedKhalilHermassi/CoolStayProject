using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Address
    {
        [Required]
        public string Street { get; set; } = String.Empty;
        [Required]
        public string Province { get; set; } = String.Empty;
        [Required]
        public string City { get; set; } = String.Empty;
        [Required]
        public string Country { get; set; } = String.Empty;
        [Required]
        public int ZipCode { get; set; } 
        
    }
}
