using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class TvSerieRepository : BaseRepository<TvSerie>, ITvSerieRepository
    {
        public TvSerieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<TvSerie> GetAll()
        {
            var tvSeries = _dbContext.WatchItems.OfType<TvSerie>()
                .Include(ts => ts.Genre)
                .Include(ts => ts.Language);

            return tvSeries;
        }

        public async override Task<IEnumerable<TvSerie>> ListAllAsync()
        {
            var tvSeries = await GetAll().ToListAsync();
            return tvSeries;
        }

        public async override Task<TvSerie> GetByIdAsync(Guid id)
        {
            var tvSerie = await GetAll().SingleOrDefaultAsync(ts => ts.Id.Equals(id));
            return tvSerie;
        }

        public async Task<IEnumerable<TvSerie>> SearchAsync(string search)
        {
            var tvSeries = await GetAll()
                .Where(ts => ts.Title.Contains(search.Trim().ToUpper()))
                .ToListAsync();

            return tvSeries;
        }
    }
}