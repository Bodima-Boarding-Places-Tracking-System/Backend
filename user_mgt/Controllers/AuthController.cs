using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using user_mgt.Models.DTOs;
using user_mgt.Services;

namespace user_mgt.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        public AuthController(IMapper mapper, IAuthService authService)
        {
            _mapper = mapper;
            _authService = authService;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto userRegistrationDto)
        {
            if (userRegistrationDto == null)
            {
                return BadRequest();
            }

            if (userRegistrationDto.Role == "Student")
            {
                var studentRegistrationDto = new StudentRegistrationDto
                {
                    FullName = userRegistrationDto.FullName,
                    Webmail = userRegistrationDto.Webmail!,
                    PasswordHash = userRegistrationDto.PasswordHash,
                    Role = userRegistrationDto.Role
                };

                var result = await _authService.RegisterStudentAsync(studentRegistrationDto);

                if (result.Success)
                {
                    var newStudent = _mapper.Map<StudentDto>(result.User);
                    return Ok(newStudent);
                } else
                {
                    return BadRequest(result.Error);
                }
            }

            return BadRequest("Invalid role specified.");
        }
    }
}
