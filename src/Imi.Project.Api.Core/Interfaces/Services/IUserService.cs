using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Services.Results;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<LoginResult> LoginAsync(LoginRequestDto loginRequestDto);
        Task<RegisterResult> RegisterAsync(RegisterUserRequestDto registerUserRequestDto);
        Task<UserProfileDto> GetCurrentUserProfileAsync();
    }
}