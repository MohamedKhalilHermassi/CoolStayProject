using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Entities.Users
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string About { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = null!;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateOnly Birthday;
        [Required]
        public Address Address { get; set; } = new Address();
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public EmergencyContact EmergencyContact { get; set; } = new EmergencyContact();
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

    }
}
