using Imi.Project.Api.Core.Dtos.Genres;
using Imi.Project.Api.Core.Dtos.Languages;

namespace Imi.Project.Api.Core.Dtos.Animes
{
    public class AnimeResponseDto : BaseDto
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public GenreResponseDto Genre { get; set; }
        public LanguageResponseDto Language { get; set; }
        public int Seasons { get; set; }
        public int TotalEpisodes { get; set; }
        public bool HasSub { get; set; }
    }
}