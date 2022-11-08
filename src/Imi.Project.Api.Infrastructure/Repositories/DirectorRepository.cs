using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class DirectorRepository : BaseRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}