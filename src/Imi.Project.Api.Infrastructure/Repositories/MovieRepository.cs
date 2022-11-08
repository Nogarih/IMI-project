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
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public override IQueryable<Movie> GetAll()
        {
            var movies = _dbContext.WatchItems.OfType<Movie>()
                .Include(m => m.Genre)
                .Include(m => m.Language)
                .Include(m => m.Director);

            return movies;
        }

        public async override Task<IEnumerable<Movie>> ListAllAsync()
        {
            var movies = await GetAll().ToListAsync();
            return movies;
        }

        public async override Task<Movie> GetByIdAsync(Guid id)
        {
            var movie = await GetAll().SingleOrDefaultAsync(m => m.Id.Equals(id));
            return movie;
        }

        public async Task<IEnumerable<Movie>> SearchAsync(string search)
        {
            var movies = await GetAll()
                .Where(m => m.Title.Contains(search.Trim().ToUpper()))
                .ToListAsync();

            return movies;
        }
    }
}