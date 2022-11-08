using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IMovieService
    {
        Task<IQueryable<Movie>> GetMovies();
        Task<IQueryable<Movie>> GetMoviesByTitle(string search);
        Task<Movie> GetMovieDetails(Guid id);
        Task<Movie> UpdateMovie(Movie movie);
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> DeleteMovie(Guid id);
    }
}
