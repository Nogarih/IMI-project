using AutoMapper;
using Imi.Project.Api.Core.Dtos.Animes;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IMapper _mapper;
        public AnimeService(IAnimeRepository animeRepository, IMapper mapper)
        {
            _animeRepository = animeRepository;
            _mapper = mapper;
        }

        public async Task<AnimeResponseDto> AddAsync(AnimeRequestDto animeRequestDto)
        {
            var anime = _mapper.Map<Anime>(animeRequestDto);
            var result = await _animeRepository.AddAsync(anime);
            var animeResponseDto = _mapper.Map<AnimeResponseDto>(result);
            return animeResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _animeRepository.DeleteAsync(id);
        }

        public async Task<AnimeResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _animeRepository.GetByIdAsync(id);
            var animeResponseDto = _mapper.Map<AnimeResponseDto>(result);
            return animeResponseDto;
        }

        public async Task<IEnumerable<AnimeResponseDto>> ListAllAsync()
        {
            var result = await _animeRepository.ListAllAsync();
            var animeResponseDto = _mapper.Map<IEnumerable<AnimeResponseDto>>(result);
            return animeResponseDto;
        }

        public async Task<IEnumerable<AnimeResponseDto>> SearchAsync(string search)
        {
            var animes = await _animeRepository.SearchAsync(search);
            return _mapper.Map<IEnumerable<AnimeResponseDto>>(animes);
        }

        public async Task<AnimeResponseDto> UpdateAsync(AnimeRequestDto animeRequestDto)
        {
            var anime = _mapper.Map<Anime>(animeRequestDto);
            var result = await _animeRepository.UpdateAsync(anime);
            var animeResponseDto = _mapper.Map<AnimeResponseDto>(result);
            return animeResponseDto;
        }
    }
}