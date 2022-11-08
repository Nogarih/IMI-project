using System;

namespace Imi.Project.Api.Core.Entities
{
    public class UserWatchItem 
    {
        //public int? CurrentEpisode { get; set; }
        //public WatchStatus? WatchStatus { get; set; }

        // Foreign keys
        public Guid UserId { get; set; }
        public Guid WatchItemId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public WatchItem WatchItem { get; set; }
    }
}