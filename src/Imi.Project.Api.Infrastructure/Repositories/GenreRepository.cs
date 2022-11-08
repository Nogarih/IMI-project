using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}