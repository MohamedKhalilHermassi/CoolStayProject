using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class EmergencyContact
    {
        [Required]
        public string Name { get; set; } = String.Empty;
        [Required]
        public string Relationship { get; set; } = String.Empty;
        [Required]
        public string PrefferedLanguage {  get; set; } = String.Empty;
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = String.Empty;
        [Required]
        public string CountryCode { get; set; } = String.Empty;
        [Required]
        public string PhoneNumber { get; set; } = String.Empty;

    }
}
