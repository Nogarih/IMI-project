using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Movies;
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
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var movie = await _movieService.ListAllAsync();
            return Ok(movie);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var movie = await _movieService.GetByIdAsync(id);
            if (movie == null)
            {
                return NotFound($"Movie with ID {id} does not exist");
            }
            return Ok(movie);
        }

        [HttpGet("search")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Search([FromQuery] string search)
        {
            if (search == null)
            {
                var movies = await _movieService.ListAllAsync();
                return Ok(movies);
            }
            else
            {
                var movies = await _movieService.SearchAsync(search);
                if (movies.Any())
                {
                    return Ok(movies);
                }
                return NotFound($"No movies found with name {search}");
            }
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(MovieRequestDto movieRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var movieResponseDto = await _movieService.AddAsync(movieRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = movieRequestDto.Id,
                Title = movieRequestDto.Title,
                ReleaseYear = movieRequestDto.ReleaseYear,
                Description = movieRequestDto.Description,
                Image = movieRequestDto.Image,
                GenreId = movieRequestDto.GenreId,
                DirectorId = movieRequestDto.DirectorId,
                LanguageId = movieRequestDto.LanguageId
            },
                movieResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(MovieRequestDto movieRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var movieResponseDto = await _movieService.UpdateAsync(movieRequestDto);
            return Ok(movieResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var movie = await _movieService.GetByIdAsync(id);

            if (movie == null)
            {
                return NotFound($"Movie with ID {id} does not exist");
            }
            await _movieService.DeleteAsync(id);
            return Ok();
        }
    }
}