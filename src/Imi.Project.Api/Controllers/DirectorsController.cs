using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Directors;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : Controller
    {
        private readonly IDirectorService _directorService;
        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var director = await _directorService.ListAllAsync();
            return Ok(director);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var director = await _directorService.GetByIdAsync(id);
            if (director == null)
            {
                return NotFound($"Director with ID {id} does not exist");
            }
            return Ok(director);
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(DirectorRequestDto directorRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var directorResponseDto = await _directorService.AddAsync(directorRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = directorRequestDto.Id,
                Name = directorRequestDto.Name
            },
                directorResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(DirectorRequestDto directorRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var directorResponseDto = await _directorService.UpdateAsync(directorRequestDto);
            return Ok(directorResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var director = await _directorService.GetByIdAsync(id);

            if (director == null)
            {
                return NotFound($"Director with ID {id} does not exist");
            }
            await _directorService.DeleteAsync(id);
            return Ok();
        }

    }
}