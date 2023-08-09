using System.ComponentModel.DataAnnotations;

namespace Innoloft.Models
{
    public class TimeZone
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TimezoneName { get; set; }
    }
}
