using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockMovieService : IMovieService
    {
        private readonly IDirectorService _directorService;
        private readonly ILanguageService _languageService;
        private readonly IGenreService _genreService;

        public MockMovieService()
        {
            _directorService = new MockDirectorService();
            _languageService = new MockLanguageService();
            _genreService = new MockGenreService();
        }
        private static List<Movie> movieList = new List<Movie>
        {
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "Joker",
                    ReleaseYear = "2019",
                    Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
                    Image = "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/608x608/products/89058/93685/Joker-2019-Final-Style-steps-Poster-buy-original-movie-posters-at-starstills__62518.1572351179.jpg?c=2",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Law Abiding Citizen",
                    ReleaseYear = "2009",
                    Description = "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free.",
                    Image = "https://i.pinimg.com/originals/98/53/97/985397db12c9ee1e9a6f1887132d7143.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Logan",
                    ReleaseYear = "2017",
                    Description = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.",
                    Image = "https://m.media-amazon.com/images/I/91WgnhSHyzL._AC_SL1500_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "The Prestige",
                    ReleaseYear = "2006",
                    Description = "After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",
                    Image = "https://i.pinimg.com/originals/b8/ca/36/b8ca36698e80e2e5b8da7ac5311dea68.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Your Name",
                    ReleaseYear = "2016",
                    Description = "Two strangers find themselves linked in a bizarre way. When a connection forms, will distance be the only thing to keep them apart?",
                    Image = "https://cdn.hmv.com/r/w-640/hmv/files/7e/7e218362-fccb-4eea-9d9a-f8df684538ec.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Tarzan",
                    ReleaseYear = "1999",
                    Description = "A man raised by gorillas must decide where he really belongs when he discovers he is a human.",
                    Image = "https://m.media-amazon.com/images/I/511JYaL4kAL._AC_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "The Thing",
                    ReleaseYear = "1982",
                    Description = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.",
                    Image = "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Gladiator",
                    ReleaseYear = "2000",
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    Image = "https://m.media-amazon.com/images/I/71sj8Yt20qL._AC_SY679_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "The Last Duel",
                    ReleaseYear = "2021",
                    Description = "King Charles VI declares that Knight Jean de Carrouges settle his dispute with his squire by challenging him to a duel.",
                    Image = "https://m.media-amazon.com/images/M/MV5BZGExZTUzYWQtYWJjZi00OTI4LTk4OGYtNTA2YzcwMmNiZTMxXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_FMjpg_UX1000_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Parasite",
                    ReleaseYear = "2019",
                    Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    Image = "https://m.media-amazon.com/images/I/91sustfojBL._AC_SL1500_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    WatchStatusId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                }
    };
        public async Task<Movie> AddMovie(Movie movie)
        {
            movieList.Add(movie);
            return await Task.FromResult(movie);
        }

        public async Task<Movie> DeleteMovie(Guid id)
        {
            var movie = movieList.FirstOrDefault(m => m.Id == id);
            movieList.Remove(movie);
            return await Task.FromResult(movie);
        }

        public async Task<Movie> GetMovieDetails(Guid id)
        {
            var movie = movieList.FirstOrDefault(m => m.Id == id);

            return await Task.FromResult(movie);
        }

        public async Task<IQueryable<Movie>> GetMovies()
        {
            var movies = movieList.AsQueryable();
            movies.ToList().ForEach(movie =>
            {
                movie.Director = _directorService.GetDirectorById(movie.DirectorId).Result;
                movie.Language = _languageService.GetLanguageById(movie.LanguageId).Result;
                movie.Genre = _genreService.GetGenreById(movie.GenreId).Result;

            });
            return await Task.FromResult(movies);
        }

        public async Task<IQueryable<Movie>> GetMoviesByTitle(string search)
        {
            var movies = movieList.AsQueryable().Where(m => m.Title.ToUpper().Contains(search.Trim().ToUpper()));
            return await Task.FromResult(movies);
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            var previousMovie = movieList.FirstOrDefault(m => m.Id == movie.Id);
            movieList.Remove(previousMovie);
            movieList.Add(movie);
            return await Task.FromResult(movie);
        }
    }
}
