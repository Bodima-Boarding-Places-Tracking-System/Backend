namespace user_mgt.Models.DTOs
{
    public class UserDto
    {
        public Guid userId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
    }
}
