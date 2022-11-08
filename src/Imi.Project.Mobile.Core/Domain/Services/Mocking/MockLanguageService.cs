using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockLanguageService : ILanguageService
    {

        private static List<Language> languageList = new List<Language>
        {
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
        };

        public async Task<Language> GetLanguageById(Guid id)
        {
            var language = languageList.FirstOrDefault(l => l.Id == id);
            return await Task.FromResult(language);
        }

        public async Task<IQueryable<Language>> GetLanguagesList()
        {
            var language = languageList.AsQueryable();
            return await Task.FromResult(language);
        }
    }
}
