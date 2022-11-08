using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class GenreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
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
                );
        }
    }
}