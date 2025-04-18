using Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Booking
    {
        [Key]
        public Guid BookingId { get; set; }    
        public Guid GuestId { get; set; }
        public Guest Guest { get; set; } = null!;
        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int NumberOfGuests { get; set; }

        //This attribute represents the modification date of a property if ever modified.
        public DateTime ModificationDate { get; set; }

        // Payments Related Attributes
        public float TaxPaid { get; set; }
        // This attribute represents the price before taxes and cleaning fee in other words = numberOfNights * pricePerNight
        public float TotalPriceOfTheStay { get; set; }
        // This attribute represents the total Price of the stay With the tax paid and the cleaning fee.
        public float TotalPriceWithTaxAndCleaningFee { get; set; }


    }
}
