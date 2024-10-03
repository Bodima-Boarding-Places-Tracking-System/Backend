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
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
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

                var result = await _userService.RegisterStudentAsync(studentRegistrationDto);

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
