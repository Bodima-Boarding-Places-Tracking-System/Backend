using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using user_mgt.Data;
using user_mgt.Models.Domains;
using user_mgt.Models.DTOs;

namespace user_mgt.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<string> _passwordHasher;
        private readonly IConfiguration _configuration;

        public UserService(AppDbContext appDbContext, IMapper mapper, IPasswordHasher<string> passwordHasher, IConfiguration configuration)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
            _configuration = configuration;
        }

        public async Task<RegistrationResponse> RegisterStudentAsync(StudentRegistrationDto student)
        {
            // Check if student already exists
            if (await _appDbContext.Students.AnyAsync(u => u.Webmail == student.Webmail))
            {
                return new RegistrationResponse
                {
                    Success = false,
                    User = null,
                    Error = "User already exists"
                };
            }

            // Hash the password
            var passwordHash = _passwordHasher.HashPassword(null, student.Password);

            // Create a new student object
            var newStudent = new Student
            {
                UserId = Guid.NewGuid(),
                FirstName = student.FirstName,
                LastName = student.LastName,
                Webmail = student.Webmail,
                Role = student.Role,
                Password = passwordHash,
                IsActive = true,
                RegistrationDate = DateTime.UtcNow,
                LastLogin = DateTime.UtcNow
            };

            // Add student to the database
            _appDbContext.Students.Add(newStudent);
            await _appDbContext.SaveChangesAsync();

            // Generate JWT token for the newly registered user
            var token = GenerateJwtToken(newStudent);

            // Map the new student to a DTO
            var userDto = _mapper.Map<UserDto>(newStudent);

            return new RegistrationResponse
            {
                Success = true,
                User = userDto,  // Return the DTO instead of the entity
                Token = token,   // Return the generated JWT token
                Error = null
            };
        }

        // Method to generate JWT Token
        private string GenerateJwtToken(Student student)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, student.UserId.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, student.Webmail),
                    new Claim(ClaimTypes.Role, student.Role),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["JwtSettings:ExpiresInMinutes"])),
                Issuer = _configuration["JwtSettings:Issuer"],
                Audience = _configuration["JwtSettings:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        public async Task<LoginResponseDto> LoginStudentAsync(LoginRequestDto loginRequestDto)
        {

            var student = await _appDbContext.Students.FirstOrDefaultAsync(u => u.Webmail == loginRequestDto.Email);

            LoginResponseDto res = new();

            // Check if student already exists
            if (student == null)
            {
                res.Success = false;
                res.User = null;
                res.Error = "User doesn't exist!";
                res.Token = null;
                return res;
            }

            // Hash the password
            var checkPassword = _passwordHasher.VerifyHashedPassword(null, student.Password, loginRequestDto.Password);

            if (checkPassword == PasswordVerificationResult.Failed)
            {
                res.Success = false;
                res.User = null;
                res.Error = "Invalid Password!";
                res.Token = null;
                return res;
            }

            // Generate JWT token for the newly registered user
            var token = GenerateJwtToken(student);

            // Map the new student to a DTO
            var userDto = _mapper.Map<UserDto>(student);

            res.Success = true;
            res.User = userDto;
            res.Error = null;
            res.Token = token;

            student.LastLogin = DateTime.Now;
            await _appDbContext.SaveChangesAsync();
            return res;
        }
    }
}
