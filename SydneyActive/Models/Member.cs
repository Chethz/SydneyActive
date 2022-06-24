using System.ComponentModel.DataAnnotations;

namespace SydneyActive.Models
{
    public class Member
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        public string ContactNumber { get; set; }
    }
}

