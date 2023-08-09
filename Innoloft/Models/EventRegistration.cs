using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Innoloft.Models
{
    public class EventRegistration
    {
        [Key]
        public int Id { get; set; }

        public int EventId { get; set; }
        public int UserId { get; set; }

        [IgnoreDataMember]
        public DateTime DateCreated { get; set; }

        [IgnoreDataMember]
        public DateTime DateUpdated { get; set; }
    }
}
