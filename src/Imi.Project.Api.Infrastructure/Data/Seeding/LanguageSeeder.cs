using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class LanguageSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "English"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Japanese"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Korean"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Dutch"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "French"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Norwegian"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "German"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Chinese"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Italian"
                },
                new Language
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Spanish"
                }
                );
        }
    }
}