using Imi.Project.Api.Core.Dtos.Animes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IAnimeService
    {
        Task<IEnumerable<AnimeResponseDto>> ListAllAsync();
        Task<AnimeResponseDto> GetByIdAsync(Guid id);
        Task<AnimeResponseDto> AddAsync(AnimeRequestDto animeRequestDto);
        Task<AnimeResponseDto> UpdateAsync(AnimeRequestDto animeRequestDto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<AnimeResponseDto>> SearchAsync(string search);
    }
}