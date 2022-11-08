using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class UserProfileDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}