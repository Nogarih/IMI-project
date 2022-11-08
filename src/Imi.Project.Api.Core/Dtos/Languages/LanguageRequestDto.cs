using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Languages
{
    public class LanguageRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
    }
}