using System.ComponentModel.DataAnnotations;

namespace user_mgt.Models.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string Role { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }   
    }
}
