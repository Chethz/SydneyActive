using System.ComponentModel;
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

        public DateTime StartDate { get; set; } = DateTime.Now;

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string ContactNumber { get; set; }
    }
}

