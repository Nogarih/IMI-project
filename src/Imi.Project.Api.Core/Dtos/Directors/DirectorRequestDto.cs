using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Directors
{
    public class DirectorRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
    }
}