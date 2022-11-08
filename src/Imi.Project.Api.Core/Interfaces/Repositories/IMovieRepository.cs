using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        Task<IEnumerable<Movie>> SearchAsync(string search);
    }
}