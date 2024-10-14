namespace user_mgt.Models.DTOs
{
    public class UserDto
    {
        public Guid userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; }

        public bool IsAdmin { get; set; } =  false;
        public bool IsActive { get; set; }
    }
}
