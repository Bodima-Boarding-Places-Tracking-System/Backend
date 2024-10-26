namespace user_mgt.Models.DTOs
{
    public class LoginResponseDto
    {
        public bool Success { get; set; }
        public UserDto? User { get; set; }
        public string? Error { get; set; }
        public string? Token { get; set; } // Add this property to store the JWT token
    }
}
