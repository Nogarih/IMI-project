using Imi.Project.Blazor.Models.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface IApiMovieService
    {
        // Movies
        Task<List<MyMovieListItem>> ListAllMoviesAsync();
        Task<MyMovieItem> GetByMovieIdAsync(Guid id);
        Task AddMovieAsync(MyMovieItem movie);
        Task UpdateMovieAsync(MyMovieItem movie);
        Task DeleteMovieAsync(MyMovieListItem movie);
        Task LoginAsync();

    }
}
