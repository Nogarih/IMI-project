using AutoMapper;
using Imi.Project.Api.Core.Dtos.Movies;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<MovieResponseDto> AddAsync(MovieRequestDto movieRequestDto)
        {
            var movie = _mapper.Map<Movie>(movieRequestDto);
            var result = await _movieRepository.AddAsync(movie);
            var movieResponseDto = _mapper.Map<MovieResponseDto>(result);
            return movieResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _movieRepository.DeleteAsync(id);
        }

        public async Task<MovieResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _movieRepository.GetByIdAsync(id);
            var movieResponseDto = _mapper.Map<MovieResponseDto>(result);
            return movieResponseDto;
        }

        public async Task<IEnumerable<MovieResponseDto>> ListAllAsync()
        {
            var result = await _movieRepository.ListAllAsync();
            var movieResponseDto = _mapper.Map<IEnumerable<MovieResponseDto>>(result);
            return movieResponseDto;
        }

        public async Task<IEnumerable<MovieResponseDto>> SearchAsync(string search)
        {
            var movies = await _movieRepository.SearchAsync(search);
            return _mapper.Map<IEnumerable<MovieResponseDto>>(movies);
        }

        public async Task<MovieResponseDto> UpdateAsync(MovieRequestDto movieRequestDto)
        {
            var movie = _mapper.Map<Movie>(movieRequestDto);
            var result = await _movieRepository.UpdateAsync(movie);
            var movieResponseDto = _mapper.Map<MovieResponseDto>(result);
            return movieResponseDto;
        }
    }
}
