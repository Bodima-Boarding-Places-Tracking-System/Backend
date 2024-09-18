﻿using user_mgt.Models.Domains;

namespace user_mgt.Models.DTOs
{
    public class RegistrationResponse
    {
        public bool Success { get; set; }
        public  User? User { get; set; }
        public string? Error { get; set; }

    }
}