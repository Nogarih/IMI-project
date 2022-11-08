using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class MovieItem
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }
        [StringLength(300, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }
        public string GenreId { get; set; }
        public InputSelectItem[] Genres { get; set; }
        public string LanguageId { get; set; }
        public InputSelectItem[] Languages { get; set; }
        public string DirectorId { get; set; }
        public InputSelectItem[] Directors { get; set; }
    }
}
