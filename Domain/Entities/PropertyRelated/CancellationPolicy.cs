using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.PropertyRelated
{
    public class CancellationPolicy
    {
        [Required]
        public bool Refundable { get; set; }
        [Required]
        public float RefundPercentage { get; set; }
        
        // The time period within which the property is refundable
        [Required]
        public int DaysNumber { get; set; }
    }
}
