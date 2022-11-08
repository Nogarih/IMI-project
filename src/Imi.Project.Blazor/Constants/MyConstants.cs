using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Constants
{
    public class MyConstants
    {
        public const string BaseUrl = "https://localhost:5001/api/";
        public static string JwtToken;

        public const string GenresUrl = "Genres";
        public const string LanguagessUrl = "Languages";
        public const string DirectorsUrl = "Directors";
        public const string MoviesUrl = "Movies";
        public const string UserssUrl = "Users";

        // AdminUser

        public const string PriAdminUsername = "PriAdmin";
        public const string PriAdminPassword = "Test123?";
    }
}