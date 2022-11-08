using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Dtos.Languages;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get()
        {
            var language = await _languageService.ListAllAsync();
            return Ok(language);
        }

        [HttpGet("{id}")]
        [Authorize(Policy = MyPolicies.CanRead)]
        public async Task<IActionResult> Get(Guid id)
        {
            var language = await _languageService.GetByIdAsync(id);
            if (language == null)
            {
                return NotFound($"Language with ID {id} does not exist");
            }
            return Ok(language);
        }

        [HttpPost]
        [Authorize(Policy = MyPolicies.CanCreate)]

        public async Task<IActionResult> Post(LanguageRequestDto languageRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            var languageResponseDto = await _languageService.AddAsync(languageRequestDto);
            return CreatedAtAction(nameof(Get), new
            {
                Id = languageRequestDto.Id,
                Name = languageRequestDto.Name
            },
                languageResponseDto);
        }

        [HttpPut]
        [Authorize(Policy = MyPolicies.CanEdit)]
        public async Task<IActionResult> Put(LanguageRequestDto languageRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            var languageResponseDto = await _languageService.UpdateAsync(languageRequestDto);
            return Ok(languageResponseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = MyPolicies.CanDelete)]

        public async Task<IActionResult> Delete(Guid id)
        {
            var language = await _languageService.GetByIdAsync(id);

            if (language == null)
            {
                return NotFound($"Language with ID {id} does not exist");
            }
            await _languageService.DeleteAsync(id);
            return Ok();
        }
    }
}