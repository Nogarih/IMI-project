using AutoMapper;
using Imi.Project.Api.Core.Dtos.Directors;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;
        public DirectorService(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public async Task<DirectorResponseDto> AddAsync(DirectorRequestDto directorRequestDto)
        {
            var director = _mapper.Map<Director>(directorRequestDto);
            var result = await _directorRepository.AddAsync(director);
            var directorResponseDto = _mapper.Map<DirectorResponseDto>(result);
            return directorResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _directorRepository.DeleteAsync(id);
        }

        public async Task<DirectorResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _directorRepository.GetByIdAsync(id);
            var directorResponseDto = _mapper.Map<DirectorResponseDto>(result);
            return directorResponseDto;
        }

        public async Task<IEnumerable<DirectorResponseDto>> ListAllAsync()
        {
            var result = await _directorRepository.ListAllAsync();
            var directorResponseDto = _mapper.Map<IEnumerable<DirectorResponseDto>>(result);
            return directorResponseDto;
        }

        public async Task<DirectorResponseDto> UpdateAsync(DirectorRequestDto directorRequestDto)
        {
            var director = _mapper.Map<Director>(directorRequestDto);
            var result = await _directorRepository.UpdateAsync(director);
            var directorResponseDto = _mapper.Map<DirectorResponseDto>(result);
            return directorResponseDto;
        }
    }
}