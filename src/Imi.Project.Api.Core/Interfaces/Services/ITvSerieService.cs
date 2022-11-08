using Imi.Project.Api.Core.Dtos.TvSeries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ITvSerieService
    {
        Task<IEnumerable<TvSerieResponseDto>> ListAllAsync();
        Task<TvSerieResponseDto> GetByIdAsync(Guid id);
        Task<TvSerieResponseDto> AddAsync(TvSerieRequestDto tvSerieRequestDto);
        Task<TvSerieResponseDto> UpdateAsync(TvSerieRequestDto tvSerieRequestDto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<TvSerieResponseDto>> SearchAsync(string search);
    }
}