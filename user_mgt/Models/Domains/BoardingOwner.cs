using System.ComponentModel.DataAnnotations;

namespace user_mgt.Models.Domains
{
    public class BoardingOwner : User
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
