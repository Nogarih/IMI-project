using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockDirectorService : IDirectorService
    {
        private static List<Director> directorsList = new List<Director>
        {
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
           };

        public Director AddDirector(string newDirector)
        {
            var director = new Director { Id = Guid.NewGuid(), Name = newDirector };
            directorsList.Add(director);
            return director;
        }

        public async Task<Director> GetDirectorById(Guid id)
        {
            var director = directorsList.FirstOrDefault(d => d.Id == id);
            return await Task.FromResult(director);
        }

        public async Task<IQueryable<Director>> GetDirectorsList()
        {
            var directors = directorsList.AsQueryable();
            return await Task.FromResult(directors);
        }
    }
}
