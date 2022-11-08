using Imi.Project.Api.Core.Dtos.Languages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageResponseDto>> ListAllAsync();
        Task<LanguageResponseDto> GetByIdAsync(Guid id);
        Task<LanguageResponseDto> AddAsync(LanguageRequestDto languageRequestDto);
        Task<LanguageResponseDto> UpdateAsync(LanguageRequestDto languageRequestDto);
        Task DeleteAsync(Guid id);
    }
}