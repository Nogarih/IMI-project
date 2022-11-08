using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockGenreService : IGenreService
    {
        private static List<Genre> genresList = new List<Genre>
        {
            new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Crime"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Drama"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Thriller"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Horror"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Action"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Romance"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Comedy"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Western"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Documentary"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Historical"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Superhero"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Fantasy"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Biographical"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Documentary"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    Name = "Sci-Fi"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Name = "Shonen"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    Name = "Shoujo"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                    Name = "Seinen"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    Name = "Josei"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                    Name = "Ecchi"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                    Name = "Harem"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                    Name = "Isekai"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    Name = "Mecha"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                    Name = "Magic"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                    Name = "Yaoi"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                    Name = "Yuri"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    Name = "Family"
                },
                new Genre
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    Name = "Animation"
                }
        };
        public async Task<Genre> GetGenreById(Guid id)
        {
            var genre = genresList.FirstOrDefault(g => g.Id == id);
            return await Task.FromResult(genre);
        }

        public async Task<IQueryable<Genre>> GetGenresList()
        {
            var genre = genresList.AsQueryable();
            return await Task.FromResult(genre);
        }
    }
}
