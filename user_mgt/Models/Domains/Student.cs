using System.ComponentModel.DataAnnotations;

namespace user_mgt.Models.Domains
{
    public class Student : User
    {
        [Required]
        public string Webmail { get; set; }
    }
}
