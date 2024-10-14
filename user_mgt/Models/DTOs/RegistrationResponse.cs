using user_mgt.Models.Domains;

namespace user_mgt.Models.DTOs
{
    public class RegistrationResponse
    {
        public bool Success { get; set; }
        public UserDto? User { get; set; }
        public string? Error { get; set; }
        public string? Token { get; set; } // Add this property to store the JWT token
    }
}
