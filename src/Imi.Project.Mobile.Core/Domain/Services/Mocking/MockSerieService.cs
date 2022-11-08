using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockSerieService : ISerieService
    {
        private readonly ILanguageService _languageService;
        private readonly IGenreService _genreService;
        public MockSerieService()
        {
            _languageService = new MockLanguageService();
            _genreService = new MockGenreService();
        }

        private static List<Serie> serieList = new List<Serie>
        {
            new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "Dexter",
                    ReleaseYear = "2006",
                    Description = "He's smart. He's lovable. He's Dexter Morgan, America's favorite serial killer, who spends his days solving crimes and nights committing them. Golden Globe winner Michael C. Hall stars in the hit SHOWTIME Original Series.",
                    Seasons = "8",
                    WatchedEpisodes = "36",
                    TotalEpisodes = "96",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://img.elo7.com.br/product/zoom/26A8796/big-poster-serie-dexter-lo01-tamanho-90x60-cm-serie.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Deadwood",
                    ReleaseYear = "2004",
                    Description = "A show set in the late 1800s, revolving around the characters of Deadwood, South Dakota; a town of deep corruption and crime.",
                    Seasons = "3",
                    WatchedEpisodes = "36",
                    TotalEpisodes = "36",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://m.media-amazon.com/images/I/918wMqktUNL._SY500_.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Breaking Bad",
                    ReleaseYear = "2008",
                    Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    Seasons = "5",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "62",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://i.pinimg.com/originals/72/83/92/728392b482329cfef27833fe110321b8.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "The Boys",
                    ReleaseYear = "2019",
                    Description = "A group of vigilantes set out to take down corrupt superheroes who abuse their superpowers.",
                    Seasons = "2",
                    WatchedEpisodes = "22",
                    TotalEpisodes = "24",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://m.media-amazon.com/images/M/MV5BNGEyOGJiNWEtMTgwMi00ODU4LTlkMjItZWI4NjFmMzgxZGY2XkEyXkFqcGdeQXVyNjcyNjcyMzQ@._V1_.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Invincible",
                    ReleaseYear = "2021",
                    Description = "An adult animated series based on the Skybound/Image comic about a teenager whose father is the most powerful superhero on the planet.",
                    Seasons = "1",
                    WatchedEpisodes = "8",
                    TotalEpisodes = "8",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://m.media-amazon.com/images/M/MV5BNWYwYjAyMzgtNzQyNC00M2JiLWI2ZTQtNzRmZThmOTk4NmRmXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Californication",
                    ReleaseYear = "2007",
                    Description = "A writer tries to juggle his career, his relationship with his daughter and his ex-girlfriend, as well as his appetite for beautiful women.",
                    Seasons = "7",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "84",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://www.themoviedb.org/t/p/original/jPqOY8cq9KXQN4bD7zJGHCNvcb4.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "The Witcher",
                    ReleaseYear = "2019",
                    Description = "Geralt of Rivia, a solitary monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.",
                    Seasons = "1",
                    WatchedEpisodes = "16",
                    TotalEpisodes = "17",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://m.media-amazon.com/images/I/713TM23V+CL._AC_SL1000_.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Squid Game",
                    ReleaseYear = "2021",
                    Description = "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes. A survival game that has a whopping 45.6 billion-won prize at stake.",
                    Seasons = "1",
                    WatchedEpisodes = "9",
                    TotalEpisodes = "9",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://0.soompi.io/wp-content/uploads/2021/08/23110511/squid-game.jpeg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "Avatar: The Last Airbender",
                    ReleaseYear = "2005",
                    Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    Seasons = "3",
                    WatchedEpisodes = "60",
                    TotalEpisodes = "62",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81KjBiKs-AL.jpg"
                },
                new Serie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Peaky Blinders",
                    ReleaseYear = "2014",
                    Description = "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                    Seasons = "5",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "36",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://i.pinimg.com/originals/b7/7c/ec/b77cec7281be7c2fc1dd793362927f76.jpg"
                }
        };

        public async Task<Serie> AddSerie(Serie serie)
        {
            serieList.Add(serie);
            return await Task.FromResult(serie);
        }

        public async Task<Serie> DeleteSerie(Guid id)
        {
            var serie = serieList.FirstOrDefault(s => s.Id == id);
            serieList.Remove(serie);
            return await Task.FromResult(serie);
        }

        public async Task<Serie> GetSerieDetails(Guid id)
        {
            var serie = serieList.FirstOrDefault(s => s.Id == id);

            return await Task.FromResult(serie);
        }

        public async Task<IQueryable<Serie>> GetSeries()
        {
            var series = serieList.AsQueryable();
            series.ToList().ForEach(serie =>
            {
                serie.Language = _languageService.GetLanguageById(serie.LanguageId).Result;
                serie.Genre = _genreService.GetGenreById(serie.GenreId).Result;
            });
            return await Task.FromResult(series);
        }

        public async Task<IQueryable<Serie>> GetSeriesByTitle(string search)
        {
            var series = serieList.AsQueryable().Where(s => s.Title.ToUpper().Contains(search.Trim().ToUpper()));
            return await Task.FromResult(series);
        }

        public async Task<Serie> UpdateSerie(Serie serie)
        {
            var previousSerie = serieList.FirstOrDefault(s => s.Id == serie.Id);
            serieList.Remove(previousSerie);
            serieList.Add(serie);
            return await Task.FromResult(serie);
        }
    }
}
