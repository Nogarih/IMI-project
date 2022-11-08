using System;

namespace Imi.Project.Api.Core.Entities
{
    public class Movie : WatchItem
    {
        // Foreign key
        public Guid DirectorId { get; set; }

        // Navigation properties
        public Director Director { get; set; }
    }
}