using user_mgt.Models.Domains;
using user_mgt.Models.DTOs;

namespace user_mgt.Services
{
    public interface IUserService
    {
        Task<RegistrationResponse> RegisterStudentAsync(StudentRegistrationDto student);
        Task<LoginResponseDto> LoginStudentAsync(LoginRequestDto loginRequestDto);
    }
}
