using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Users
{
    public class Guest : User
    {
        [Required]
        public Wishlist Wishlist { get; set; } = new Wishlist();
        public ICollection<Booking> Bookings { get; set; } = [];

    }
}
