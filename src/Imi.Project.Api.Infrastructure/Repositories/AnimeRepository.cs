using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class AnimeRepository : BaseRepository<Anime>, IAnimeRepository
    {
        public AnimeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IQueryable<Anime> GetAll()
        {
            var animes = _dbContext.WatchItems.OfType<Anime>()
                .Include(a => a.Genre)
                .Include(a => a.Language);

            return animes;
        }

        public async override Task<IEnumerable<Anime>> ListAllAsync()
        {
            var animes = await GetAll().ToListAsync();
            return animes;
        }

        public async override Task<Anime> GetByIdAsync(Guid id)
        {
            var anime = await GetAll().SingleOrDefaultAsync(a => a.Id.Equals(id));
            return anime;
        }

        public async Task<IEnumerable<Anime>> SearchAsync(string search)
        {
            var animes = await GetAll()
                .Where(a => a.Title.Contains(search.Trim().ToUpper()))
                .ToListAsync();

            return animes;
        }
    }
}