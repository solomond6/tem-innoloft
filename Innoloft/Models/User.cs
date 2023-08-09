using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Innoloft.Models
{
    [DataContract]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [IgnoreDataMember]
        public DateTime DateCreated { get; set; }

        [IgnoreDataMember]
        public DateTime DateUpdated { get; set; }
    }
}
