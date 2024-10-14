using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace user_mgt.Models.Domains
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; } 

        public bool IsAdmin { get; set; } = false;
        public bool IsActive { get; set; }
    }
}
