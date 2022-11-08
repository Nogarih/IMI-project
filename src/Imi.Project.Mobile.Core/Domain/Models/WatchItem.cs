using Imi.Project.Mobile.Core.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class WatchItem : ModelBase
    {
        public string WatchStatus { get; set; }
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public Language Language { get; set; }
        public Genre Genre { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }

        public Guid GenreId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid WatchStatusId { get; set; }
    }
}
