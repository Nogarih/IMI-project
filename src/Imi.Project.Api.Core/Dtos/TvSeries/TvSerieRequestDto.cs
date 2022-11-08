using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.TvSeries
{
    public class TvSerieRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }
        public int Seasons { get; set; }
        public int TotalEpisodes { get; set; }
    }
}