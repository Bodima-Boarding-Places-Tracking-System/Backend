﻿namespace user_mgt.Models.DTOs
{
    public class UserRegistrationDto
    {
        public string FullName { get; set; }
        public string Role { get; set; }
        public string PasswordHash { get; set; }
        public string? Email { get; set; }
        public string? Webmail { get; set; }
        public string? Phone {  get; set; }
    }
}
