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

            if (userRegistrationDto.Role == "student")
            {
                var studentRegistrationDto = new StudentRegistrationDto
                {
                    FirstName = userRegistrationDto.FirstName,
                    LastName = userRegistrationDto.LastName,
                    Webmail = userRegistrationDto.Webmail!,
                    Password = userRegistrationDto.Password,
                    Role = userRegistrationDto.Role
                };

                var result = await _userService.RegisterStudentAsync(studentRegistrationDto);

                if (result.Success)
                {
                    var newStudent = _mapper.Map<StudentDto>(result.User);
                    return Ok(result);
                } else
                {
                    return BadRequest(new {result.Error});
                }
            }

            return BadRequest("Invalid role specified.");
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            if(loginRequestDto == null)
            {
                return BadRequest();
            }

            if (loginRequestDto.Role == "student")
            {
                var result = await _userService.LoginStudentAsync(loginRequestDto);

                if (result.Success) 
                {
                    return Ok(result);
                }

                if (result.Success == false)
                {
                    var error = result.Error;
                    return BadRequest(new { error });
                }
            }

            return BadRequest(new { error="Invalid role specified!" });
        }
    }
}
