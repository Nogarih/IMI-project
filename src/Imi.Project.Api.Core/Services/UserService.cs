using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Services.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public UserService(SignInManager<User> signInManager,
            UserManager<User> userManager,
            IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task<UserProfileDto> GetCurrentUserProfileAsync()
        {
            var currentHttpContextUser = _httpContextAccessor.HttpContext.User.Identities.FirstOrDefault();

            if(currentHttpContextUser != null)
            {
                var currentUserId = currentHttpContextUser.FindFirst(ClaimTypes.NameIdentifier).Value;
                var user = await _userManager.FindByIdAsync(currentUserId);

                var userProfile = new UserProfileDto
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Birthday = user.Birthday
                };
                return userProfile;
            }
            return null;
        }

        public async Task<LoginResult> LoginAsync(LoginRequestDto loginRequestDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginRequestDto.UserName, loginRequestDto.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var appUser = await _userManager.FindByNameAsync(loginRequestDto.UserName);
                var claims = await GetClaimsFromUser(appUser);
                var jwtToken = GetJwtTokenForUser(appUser, claims);


                // Creating the ClaimsIdentity
                var identity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);

                // Creating the ClaimsPrincipal
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                // Sign in, in the context
                await _httpContextAccessor.HttpContext.SignInAsync(claimsPrincipal);

                return new LoginResult { Succeeded = true, JwtToken = jwtToken };
            }
            else
            {
                return new LoginResult
                {
                    Succeeded = false,
                    ErrorMessages = new List<string>
                    {
                        "Something went wrong, please try again"
                    },
                    JwtToken = null
                };
            }
        }

        public async Task<RegisterResult> RegisterAsync(RegisterUserRequestDto registerUserRequestDto)
        {
            User newUser = new User
            {
                UserName = registerUserRequestDto.UserName,
                Email = registerUserRequestDto.Email,
                Birthday = registerUserRequestDto.Birthday,
                HasApprovedTermsAndConditions = registerUserRequestDto.AcceptTermsAndConditions
            };

            var resultCreateUser = await _userManager.CreateAsync(newUser, registerUserRequestDto.Password);

            if (resultCreateUser.Succeeded)
            {
                var resultCreateClaim = await _userManager.AddClaimsAsync(newUser, new[]
                {
                    new Claim(ClaimTypes.Email, registerUserRequestDto.Email),
                    new Claim(ClaimTypes.Role, MyUserRoles.User),
                    new Claim(MyClaimTypes.UserNameClaimType, registerUserRequestDto.UserName),
                    new Claim(MyClaimTypes.UserIdClaimType, registerUserRequestDto.Id.ToString()),
                    new Claim(MyClaimTypes.HasApprovedTermsClaimType, registerUserRequestDto.AcceptTermsAndConditions.ToString(), ClaimValueTypes.Boolean)
                });

                if (resultCreateUser.Succeeded)
                {
                    return new RegisterResult { Succeeded = true };

                }
                else
                {
                    return GetRegisterResultWithErrorMessages(resultCreateClaim);
                }
            }
            else
            {
                return GetRegisterResultWithErrorMessages(resultCreateUser);
            }
        }

        private RegisterResult GetRegisterResultWithErrorMessages(IdentityResult identityResult)
        {
            var errorMessages = new List<string>();

            foreach (var identityError in identityResult.Errors)
            {
                errorMessages.Add($"{identityError.Code} - {identityError.Description}{Environment.NewLine}");
            }

            return new RegisterResult { Succeeded = false, ErrorMessages = errorMessages };
        }
        private async Task<IList<Claim>> GetClaimsFromUser(User user)
        {
            var claims = await _userManager.GetClaimsAsync(user);
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.NameId, user.Id));

            foreach (var role in await _userManager.GetRolesAsync(user))
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private string GetJwtTokenForUser(User user, IList<Claim> claims)
        {
            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
            (
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey),
                SecurityAlgorithms.HmacSha256)
            );

            var serializedToken = new JwtSecurityTokenHandler().WriteToken(token); //serialize the token
            return serializedToken;

        }
    }
}