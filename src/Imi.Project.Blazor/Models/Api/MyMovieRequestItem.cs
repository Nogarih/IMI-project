using System;

namespace Imi.Project.Blazor.Models.Api
{
    public class MyMovieRequestItem 
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid DirectorId { get; set; }
    }
}