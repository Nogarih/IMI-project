using AutoMapper;
using Imi.Project.Api.Core.Dtos.Genres;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        public GenreService(IGenreRepository genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }
        public async Task<GenreResponseDto> AddAsync(GenreRequestDto genreRequestDto)
        {
            var genre = _mapper.Map<Genre>(genreRequestDto);
            var result = await _genreRepository.AddAsync(genre);
            var genreResponseDto = _mapper.Map<GenreResponseDto>(result);
            return genreResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _genreRepository.DeleteAsync(id);
        }

        public async Task<GenreResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _genreRepository.GetByIdAsync(id);
            var genreResponseDto = _mapper.Map<GenreResponseDto>(result);
            return genreResponseDto;
        }

        public async Task<IEnumerable<GenreResponseDto>> ListAllAsync()
        {
            var result = await _genreRepository.ListAllAsync();
            var genreResponseDto = _mapper.Map<IEnumerable<GenreResponseDto>>(result);
            return genreResponseDto;
        }

        public async Task<GenreResponseDto> UpdateAsync(GenreRequestDto genreRequestDto)
        {
            var genre = _mapper.Map<Genre>(genreRequestDto);
            var result = await _genreRepository.UpdateAsync(genre);
            var genreResponseDto = _mapper.Map<GenreResponseDto>(result);
            return genreResponseDto;
        }
    }
}