using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public abstract class WatchItem : BaseEntity
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // Foreign key
        public Guid LanguageId { get; set; }
        public Guid GenreId { get; set; }


        // Navigation properties
        public Language Language { get; set; }
        public Genre Genre { get; set; }
        public ICollection<UserWatchItem> UserWatchItems { get; set; }
    }
}