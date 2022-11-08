using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IAnimeRepository : IBaseRepository<Anime>
    {
        Task<IEnumerable<Anime>> SearchAsync(string search);
    }
}