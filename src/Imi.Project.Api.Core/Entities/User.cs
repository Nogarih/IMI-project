using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Imi.Project.Api.Core.Entities
{
    public class User : IdentityUser
    {
        public DateTime Birthday { get; set; }
        public bool? HasApprovedTermsAndConditions { get; set; }


        // Navigation properties
        public ICollection<UserWatchItem> UserWatchItems { get; set; }
    }
}