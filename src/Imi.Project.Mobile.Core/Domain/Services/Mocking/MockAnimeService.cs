using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockAnimeService : IAnimeService
    {
        private readonly ILanguageService _languageService;
        private readonly IGenreService _genreService;

        public MockAnimeService()
        {
            _languageService = new MockLanguageService();
            _genreService = new MockGenreService();
        }

        private static List<Anime> animesList = new List<Anime>
        {
            new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "My Hero Academia",
                    ReleaseYear = "2016",
                    Description = "A superhero-loving boy without any powers is determined to enroll in a prestigious hero academy and learn what it really means to be a hero.",
                    Seasons = "5",
                    WatchedEpisodes = "36",
                    TotalEpisodes = "117",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://static.posters.cz/image/750/posters/my-hero-academia-cobalt-blast-group-i63331.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Jujutsu Kaisen",
                    ReleaseYear = "2020",
                    Description = "A boy swallows a cursed talisman - the finger of a demon - and becomes cursed himself. He enters a shaman's school to be able to locate the demon's other body parts and thus exorcise himself.",
                    Seasons = "1",
                    WatchedEpisodes = "24",
                    TotalEpisodes = "24",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://www.themoviedb.org/t/p/original/mJVUZpPR4BdZzLWyP51h8pOU1RO.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Bleach",
                    ReleaseYear = "2004",
                    Description = "High school student Ichigo Kurosaki, who has the ability to see ghosts, gains soul reaper powers from Rukia Kuchiki and sets out to save the world from Hollows.",
                    Seasons = "16",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "369",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://i.pinimg.com/originals/bc/c9/51/bcc951d89f74a93512439c964851215c.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "Death Note",
                    ReleaseYear = "2019",
                    Description = "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.",
                    Seasons = "1",
                    WatchedEpisodes = "20",
                    TotalEpisodes = "37",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://m.media-amazon.com/images/I/716ASj7z2GL._AC_SL1000_.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Dragon Ball Z",
                    ReleaseYear = "1996",
                    Description = "After learning that he is from another planet, a warrior named Goku and his friends are prompted to defend it from an onslaught of extraterrestrial enemies.",
                    Seasons = "16",
                    WatchedEpisodes = "227",
                    TotalEpisodes = "227",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://m.media-amazon.com/images/M/MV5BMGMyOThiMGUtYmFmZi00YWM0LWJiM2QtZGMwM2Q2ODE4MzhhXkEyXkFqcGdeQXVyMjc2Nzg5OTQ@._V1_.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Naruto",
                    ReleaseYear = "2007",
                    Description = "Naruto Uzumaki, is a loud, hyperactive, adolescent ninja who constantly searches for approval and recognition, as well as to become Hokage, who is acknowledged as the leader and strongest of all ninja in the village.",
                    Seasons = "21",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "502",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://www.ecranlarge.com/uploads/image/001/151/affiche-1151327.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "Kaichou wa Maid-sama!",
                    ReleaseYear = "2010",
                    Description = "Ayuzawa Misaki serves as the student council president at Seika High. However, unbeknownst to her classmates, she works part-time as an employee at a Maid Cafe. Usui Takumi, a boy from her school, discovers this secret.",
                    Seasons = "1",
                    WatchedEpisodes = "28",
                    TotalEpisodes = "28",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://www.themoviedb.org/t/p/original/igkn0M1bgMeATz59LShvVxZNdVd.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Shingeki no Kyojin",
                    ReleaseYear = "2013",
                    Description = "After his hometown is destroyed and his mother is killed, young Eren Jaeger vows to cleanse the earth of the giant humanoid Titans that have brought humanity to the brink of extinction.",
                    Seasons = "4",
                    WatchedEpisodes = "10",
                    TotalEpisodes = "86",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Image = "https://cdn.europosters.eu/image/750/posters/attack-on-titan-shingeki-no-kyojin-key-art-i22808.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "Gintama",
                    ReleaseYear = "2005",
                    Description = "In an era where aliens have invaded and taken over feudal Tokyo, an unemployed samurai finds work however he can.",
                    Seasons = "8",
                    WatchedEpisodes = "0",
                    TotalEpisodes = "375",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Image = "https://www.themoviedb.org/t/p/w500/5AX6ObPYZN0RP3L0Eu7s0RCLxeX.jpg"
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Fruits Basket",
                    ReleaseYear = "2019",
                    Description = "After Tohru is taken in by the Soma family, she learns that twelve family members transform involuntarily into animals of the Chinese zodiac and helps them deal with the emotional pain caused by the transformations.",
                    Seasons = "5",
                    WatchedEpisodes = "63",
                    TotalEpisodes = "63",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Image = "https://image.animedigitalnetwork.fr/license/fruitsbasket/tv/web/affiche_370x0.jpg"
                }
        };

        public async Task<Anime> AddAnime(Anime anime)
        {
            animesList.Add(anime);
            return await Task.FromResult(anime);
        }

        public async Task<Anime> DeleteAnime(Guid id)
        {
            var anime = animesList.FirstOrDefault(a => a.Id == id);
            animesList.Remove(anime);
            return await Task.FromResult(anime);
        }

        public async Task<Anime> GetAnimeDetails(Guid id)
        {
            var anime = animesList.FirstOrDefault(a => a.Id == id);

            return await Task.FromResult(anime);
        }

        public async Task<IQueryable<Anime>> GetAnimes()
        {
            var animes = animesList.AsQueryable();
            animes.ToList().ForEach(anime =>
            {
                anime.Language = _languageService.GetLanguageById(anime.LanguageId).Result;
                anime.Genre = _genreService.GetGenreById(anime.GenreId).Result;
            });
            return await Task.FromResult(animes);
        }

        public async Task<IQueryable<Anime>> GetAnimesByTitle(string search)
        {
            var animes = animesList.AsQueryable().Where(a => a.Title.ToUpper().Contains(search.Trim().ToUpper()));
            return await Task.FromResult(animes);
        }

        public async Task<Anime> UpdateAnime(Anime anime)
        {
            var previousAnime = animesList.FirstOrDefault(a => a.Id == anime.Id);
            animesList.Remove(previousAnime);
            animesList.Add(anime);
            return await Task.FromResult(anime);
        }
    }
}
