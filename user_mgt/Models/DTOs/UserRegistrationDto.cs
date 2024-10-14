namespace user_mgt.Models.DTOs
{
    public class UserRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Webmail { get; set; }
        public string? Phone {  get; set; }
    }
}
