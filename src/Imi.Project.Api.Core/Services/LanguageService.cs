using AutoMapper;
using Imi.Project.Api.Core.Dtos.Languages;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IMapper _mapper;
        public LanguageService(ILanguageRepository languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        public async Task<LanguageResponseDto> AddAsync(LanguageRequestDto languageRequestDto)
        {
            var language = _mapper.Map<Language>(languageRequestDto);
            var result = await _languageRepository.AddAsync(language);
            var languageResponseDto = _mapper.Map<LanguageResponseDto>(result);
            return languageResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _languageRepository.DeleteAsync(id);
        }

        public async Task<LanguageResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _languageRepository.GetByIdAsync(id);
            var languageResponseDto = _mapper.Map<LanguageResponseDto>(result);
            return languageResponseDto;
        }

        public async Task<IEnumerable<LanguageResponseDto>> ListAllAsync()
        {
            var result = await _languageRepository.ListAllAsync();
            var languageResponseDto = _mapper.Map<IEnumerable<LanguageResponseDto>>(result);
            return languageResponseDto;
        }

        public async Task<LanguageResponseDto> UpdateAsync(LanguageRequestDto languageRequestDto)
        {
            var language = _mapper.Map<Language>(languageRequestDto);
            var result = await _languageRepository.UpdateAsync(language);
            var languageResponseDto = _mapper.Map<LanguageResponseDto>(result);
            return languageResponseDto;
        }
    }
}