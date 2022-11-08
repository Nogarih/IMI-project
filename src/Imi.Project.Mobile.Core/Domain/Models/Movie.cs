using Imi.Project.Mobile.Core.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Movie : WatchItem
    {
        public Director Director { get; set; }

        public Guid DirectorId { get; set; }
    }
}
