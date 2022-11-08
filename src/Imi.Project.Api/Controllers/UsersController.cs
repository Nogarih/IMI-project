using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            try
            {
                var result = await _userService.LoginAsync(loginRequestDto);

                if (result.Succeeded)
                {
                    var loginResponseDto = new LoginResponseDto { JwtToken = result.JwtToken };
                    return Ok(loginResponseDto);
                }
                else
                {
                    return Unauthorized(result.ErrorMessages);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Source, ex.Message);
                return BadRequest(ModelState);
            }
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterUserRequestDto registerUserRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            try
            {
                var result = await _userService.RegisterAsync(registerUserRequestDto);
                if (result.Succeeded)
                {
                    return Ok("Thank you for your registration, you can now login");
                }
                else
                {
                    return BadRequest(result.ErrorMessages);
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(ex.Source, ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}