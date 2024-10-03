using AutoMapper;
using Microsoft.EntityFrameworkCore;
using user_mgt.Data;
using user_mgt.Models.Domains;
using user_mgt.Models.DTOs;

namespace user_mgt.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public UserService(AppDbContext appDbContext, IMapper mapper) 
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task<RegistrationResponse> RegisterStudentAsync(StudentRegistrationDto student)
        {
            if (await _appDbContext.Students.AnyAsync(u => u.Webmail == student.Webmail)) 
            {
                return new RegistrationResponse { 
                    Success = false,
                    User = null,
                    Error =  "User already exists"
                };
            }

            var newStudent = new Student
            {
                UserId = Guid.NewGuid(),
                FullName = student.FullName,
                Webmail = student.Webmail,
                Role = student.Role,
                Password = student.PasswordHash,
                IsActive = true,
                RegistrationDate = DateTime.Now,
                LastLogin = DateTime.Now,
            };

            _appDbContext.Students.Add(newStudent);
            await _appDbContext.SaveChangesAsync();

            return new RegistrationResponse { 
                Success = true,
                User = newStudent,
                Error = null
            };

        }
    }
}
