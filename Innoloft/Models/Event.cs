using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Innoloft.Models
{
    [DataContract]
    public class Event
    {
        [IgnoreDataMember]
        [Key]
        public int Id { get; set; }

        [Required]
        [IgnoreDataMember]
        public string Title { get; set; }

        [IgnoreDataMember]
        public string? Description { get; set; }

        [Required]
        [IgnoreDataMember]
        public DateTime StartDate { get; set; }

        [Required]
        [IgnoreDataMember]
        public DateTime EndDate { get; set; }

        [IgnoreDataMember]
        public int? TimezoneId { get; set; }

        [IgnoreDataMember]
        public int? CreatedBy { get; set; }

        [IgnoreDataMember]
        public DateTime DateCreated { get; set; }

        [IgnoreDataMember]
        public DateTime DateUpdated { get; set; }
    }
}
