using AutoMapper;
using Imi.Project.Api.Core.Dtos.TvSeries;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class TvSerieService : ITvSerieService
    {
        private readonly ITvSerieRepository _tvSerieRepository;
        private readonly IMapper _mapper;
        public TvSerieService(ITvSerieRepository tvSerieRepository, IMapper mapper)
        {
            _tvSerieRepository = tvSerieRepository;
            _mapper = mapper;
        }

        public async Task<TvSerieResponseDto> AddAsync(TvSerieRequestDto tvSerieRequestDto)
        {
            var tvSerie = _mapper.Map<TvSerie>(tvSerieRequestDto);
            var result = await _tvSerieRepository.AddAsync(tvSerie);
            var tvSerieResponseDto = _mapper.Map<TvSerieResponseDto>(result);
            return tvSerieResponseDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _tvSerieRepository.DeleteAsync(id);
        }

        public async Task<TvSerieResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _tvSerieRepository.GetByIdAsync(id);
            var tvSerieResponseDto = _mapper.Map<TvSerieResponseDto>(result);
            return tvSerieResponseDto;
        }

        public async Task<IEnumerable<TvSerieResponseDto>> ListAllAsync()
        {
            var result = await _tvSerieRepository.ListAllAsync();
            var tvSerieResponseDto = _mapper.Map<IEnumerable<TvSerieResponseDto>>(result);
            return tvSerieResponseDto;
        }

        public async Task<IEnumerable<TvSerieResponseDto>> SearchAsync(string search)
        {
            var tvSeries = await _tvSerieRepository.SearchAsync(search);
            return _mapper.Map<IEnumerable<TvSerieResponseDto>>(tvSeries);
        }

        public async Task<TvSerieResponseDto> UpdateAsync(TvSerieRequestDto tvSerieRequestDto)
        {
            var tvSerie = _mapper.Map<TvSerie>(tvSerieRequestDto);
            var result = await _tvSerieRepository.UpdateAsync(tvSerie);
            var tvSerieResponseDto = _mapper.Map<TvSerieResponseDto>(result);
            return tvSerieResponseDto;
        }
    }
}