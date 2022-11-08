using Imi.Project.Blazor.Models.Api.Base;
using System;

namespace Imi.Project.Blazor.Models.Api
{
    public class MyMovieItem : BaseModel
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string GenreId { get; set; }
        public InputSelectItem[] Genres { get; set; }
        public string LanguageId { get; set; }
        public InputSelectItem[] Languages { get; set; }
        public string DirectorId { get; set; }
        public InputSelectItem[] Directors { get; set; }
    }
}