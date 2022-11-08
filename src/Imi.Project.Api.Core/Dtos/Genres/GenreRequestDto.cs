using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Genres
{
    public class GenreRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
    }
}