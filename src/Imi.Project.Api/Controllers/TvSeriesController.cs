using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.TvSeries;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvSeriesController : Controller
    {
        private readonly ITvSerieService _tvSerieService;

        public TvSeriesController(ITvSerieService tvSerieService)
        {
            _tvSerieService = tvSerieService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var tvSerie = await _tvSerieService.ListAllAsync();
            return Ok(tvSerie);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var tvSerie = await _tvSerieService.GetByIdAsync(id);
            if (tvSerie == null)
            {
                return NotFound($"TvSerie with ID {id} does not exist");
            }
            return Ok(tvSerie);
        }

        [HttpGet("search")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Search([FromQuery] string search)
        {
            if (search == null)
            {
                var tvSeries = await _tvSerieService.ListAllAsync();
                return Ok(tvSeries);
            }
            else
            {
                var tvSeries = await _tvSerieService.SearchAsync(search);
                if (tvSeries.Any())
                {
                    return Ok(tvSeries);
                }
                return NotFound($"No tvseries found with name {search}");
            }
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(TvSerieRequestDto tvSerieRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var tvSerieResponseDto = await _tvSerieService.AddAsync(tvSerieRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = tvSerieRequestDto.Id,
                Title = tvSerieRequestDto.Title,
                ReleaseYear = tvSerieRequestDto.ReleaseYear,
                Description = tvSerieRequestDto.Description,
                Image = tvSerieRequestDto.Image,
                GenreId = tvSerieRequestDto.GenreId,
                LanguageId = tvSerieRequestDto.LanguageId,
                Seasons = tvSerieRequestDto.Seasons,
                TotalEpisodes = tvSerieRequestDto.TotalEpisodes
            },
                tvSerieResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(TvSerieRequestDto tvSerieRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var tvSerieResponseDto = await _tvSerieService.UpdateAsync(tvSerieRequestDto);
            return Ok(tvSerieResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var tvSerie = await _tvSerieService.GetByIdAsync(id);

            if (tvSerie == null)
            {
                return NotFound($"TvSerie with ID {id} does not exist");
            }
            await _tvSerieService.DeleteAsync(id);
            return Ok();
        }
    }
}