using user_mgt.Models.Domains;
using user_mgt.Models.DTOs;

namespace user_mgt.Services
{
    public interface IAuthService
    {
        Task<RegistrationResponse> RegisterStudentAsync(StudentRegistrationDto student);
    }
}
