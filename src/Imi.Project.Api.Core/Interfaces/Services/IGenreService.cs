using Imi.Project.Api.Core.Dtos.Genres;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreResponseDto>> ListAllAsync();
        Task<GenreResponseDto> GetByIdAsync(Guid id);
        Task<GenreResponseDto> AddAsync(GenreRequestDto genreRequestDto);
        Task<GenreResponseDto> UpdateAsync(GenreRequestDto genreRequestDto);
        Task DeleteAsync(Guid id);
    }
}