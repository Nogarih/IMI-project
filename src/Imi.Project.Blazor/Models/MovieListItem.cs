using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class MovieListItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
    }
}
