using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DirectorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Todd Phillips"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Eric Kripke"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Christopher Nolan"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Vince Gilligan"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Chris Buck"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "F.Gary Gray"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "James Manos Jr."
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "David Milch"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Robert Kirkman"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Ridley Scott"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "John Carpenter"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Bong Joon Ho"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "James Mangold"
                },
                new Director
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Makoto Shinkai"
                }
                );
        }
    }
}