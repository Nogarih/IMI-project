using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Models.GuessingGame;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface IGuessingGameService
    {
        Task<GameItem> GetRandomMovie();
        Task<string> MakeWordSecret(string word);
    }
}