using Imi.Project.Mobile.Core.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Anime : WatchItem
    {
        public string Seasons { get; set; }
        public string WatchedEpisodes { get; set; }
        public string TotalEpisodes { get; set; }
    }
}
