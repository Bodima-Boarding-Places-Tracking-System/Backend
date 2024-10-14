using System.ComponentModel.DataAnnotations;

namespace user_mgt.Models.DTOs
{
    public class StudentDto : UserDto
    {
        [Required]
        public string Webmail { get; set; }
    }
}
