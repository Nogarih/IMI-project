using Imi.Project.Blazor.Models.Api.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models.Api
{
    public class MyMovieListItem : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}