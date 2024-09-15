using System.ComponentModel.DataAnnotations;

namespace boarding_mgt.Models
{
    public class Boarding
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }


    }
}
