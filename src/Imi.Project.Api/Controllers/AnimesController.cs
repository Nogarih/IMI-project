using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Animes;
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
    public class AnimesController : Controller
    {
        private readonly IAnimeService _animeService;

        public AnimesController(IAnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var anime = await _animeService.ListAllAsync();
            return Ok(anime);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var anime = await _animeService.GetByIdAsync(id);
            if (anime == null)
            {
                return NotFound($"Anime with ID {id} does not exist");
            }
            return Ok(anime);
        }

        [HttpGet("search")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Search([FromQuery] string search)
        {
            if (search == null)
            {
                var animes = await _animeService.ListAllAsync();
                return Ok(animes);
            }
            else
            {
                var animes = await _animeService.SearchAsync(search);
                if (animes.Any())
                {
                    return Ok(animes);
                }
                return NotFound($"No animes found with name {search}");
            }
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(AnimeRequestDto animeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var animeResponseDto = await _animeService.AddAsync(animeRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = animeRequestDto.Id,
                Title = animeRequestDto.Title,
                ReleaseYear = animeRequestDto.ReleaseYear,
                Description = animeRequestDto.Description,
                Image = animeRequestDto.Image,
                GenreId = animeRequestDto.GenreId,
                LanguageId = animeRequestDto.LanguageId,
                Seasons = animeRequestDto.Seasons,
                TotalEpisodes = animeRequestDto.TotalEpisodes,
                HasSub = animeRequestDto.HasSub

            },
                animeResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(AnimeRequestDto animeRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var animeResponseDto = await _animeService.UpdateAsync(animeRequestDto);
            return Ok(animeResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var anime = await _animeService.GetByIdAsync(id);

            if (anime == null)
            {
                return NotFound($"Anime with ID {id} does not exist");
            }
            await _animeService.DeleteAsync(id);
            return Ok();
        }
    }
}