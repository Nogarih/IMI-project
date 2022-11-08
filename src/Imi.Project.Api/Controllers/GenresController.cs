using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Genres;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : Controller
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var genre = await _genreService.ListAllAsync();
            return Ok(genre);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var genre = await _genreService.GetByIdAsync(id);
            if (genre == null)
            {
                return NotFound($"Genre with ID {id} does not exist");
            }
            return Ok(genre);
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(GenreRequestDto genreRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var genreResponseDto = await _genreService.AddAsync(genreRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = genreRequestDto.Id,
                Name = genreRequestDto.Name
            },
                genreResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(GenreRequestDto genreRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var genreResponseDto = await _genreService.UpdateAsync(genreRequestDto);
            return Ok(genreResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var genre = await _genreService.GetByIdAsync(id);

            if (genre == null)
            {
                return NotFound($"Genre with ID {id} does not exist");
            }
            await _genreService.DeleteAsync(id);
            return Ok();
        }
    }
}