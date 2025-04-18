using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Users
{
    public class Host : User
    {
        [Required]
        public bool SuperHost { get; set; } = false;
        [Required]
        public float RatingAvg { get; set; } = 0;
        [Required]
        public int TotalRatings { get; set; } = 0;


    }
}
