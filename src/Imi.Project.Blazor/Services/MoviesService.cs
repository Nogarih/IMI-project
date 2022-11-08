using Imi.Project.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class MoviesService : ICRUDService<MovieListItem, MovieItem>
    {
        static InputSelectItem[] genres = new InputSelectItem[]
        {
            new InputSelectItem(){Value="1", Label="Crime"},
            new InputSelectItem(){Value="2", Label="Superhero"},
            new InputSelectItem(){Value="3", Label="History"},
            new InputSelectItem(){Value="4", Label="Horror"}
        };

        static InputSelectItem[] languages = new InputSelectItem[]
        {
            new InputSelectItem(){Value="1", Label="English"},
            new InputSelectItem(){Value="2", Label="Japanese"},
            new InputSelectItem(){Value="3", Label="Korean"},
            new InputSelectItem(){Value="4", Label="French"}
        };

        static InputSelectItem[] directors = new InputSelectItem[]
        {
            new InputSelectItem(){Value="1", Label="Todd Phillips"},
            new InputSelectItem(){Value="2", Label="Eric Kripke"},
            new InputSelectItem(){Value="3", Label="Christopher Nolan"},
            new InputSelectItem(){Value="4", Label="Vince Gilligan"}
        };
        static List<MovieItem> movies = new List<MovieItem>
        {
            new MovieItem() {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Title = "Joker",
                GenreId = "1", // Crime
                LanguageId = "1", // English
                DirectorId = "1", // Todd Phillips
                Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker."
            },
            new MovieItem() {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Title = "Logan",
                GenreId = "2", // Superhero
                LanguageId = "1", // English
                DirectorId = "2", // Eric Kripke
                Description = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety."
            },
            new MovieItem() {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                Title = "The Last Duel",
                GenreId = "3", // History
                LanguageId = "4", // French
                DirectorId = "3", // Christopher Nolan
                Description = "King Charles VI declares that Knight Jean de Carrouges settle his dispute with his squire by challenging him to a duel."
            },
            new MovieItem() {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                Title = "The Thing",
                GenreId = "4", // Horror
                LanguageId = "2", // Japanese
                DirectorId = "4", // Vince Gilligan
                Description = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims."
            },

        };

        public Task Create(MovieItem item)
        {
            item.Id = Guid.NewGuid();
            movies.Add(item);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var movie = movies.SingleOrDefault(mi => mi.Id == id);
            if (movie == null) throw new ArgumentException("Movie not found!");
            movies.Remove(movie);
            return Task.CompletedTask;
        }

        public Task<MovieItem> Get(Guid id)
        {
            var movie = movies.SingleOrDefault(mi => mi.Id == id);
            movie.Genres = genres;
            movie.Languages = languages;
            movie.Directors = directors;
            return Task.FromResult(movie);
        }

        public Task<MovieListItem[]> GetList()
        {
            return Task.FromResult(
                movies.Select(mi => new MovieListItem()
                {
                    Id = mi.Id,
                    Title = mi.Title,
                    Genre = genres
                    .Where(g => g.Value == mi.GenreId)
                    .Select(g => g.Label)
                    .SingleOrDefault(),
                    Language = languages
                    .Where(l => l.Value == mi.GenreId)
                    .Select(l => l.Label)
                    .SingleOrDefault(),
                    Director = directors
                    .Where(d => d.Value == mi.GenreId)
                    .Select(d => d.Label)
                    .SingleOrDefault()
                }).ToArray()
            );
        }

        public Task<MovieItem> GetNew()
        {
            var movie = new MovieItem();
            movie.Genres = genres;
            movie.Languages = languages;
            movie.Directors = directors;
            movie.GenreId = genres.First().Value;

            return Task.FromResult(movie);
        }

        public Task Update(MovieItem item)
        {
            var movie = movies.SingleOrDefault(mi => mi.Id == item.Id);
            if (movie == null) throw new ArgumentException("Movie not found!");
            movie.Title = item.Title;
            movie.GenreId = item.GenreId;
            movie.LanguageId = item.LanguageId;
            movie.DirectorId = item.DirectorId;
            movie.Description = item.Description;

            return Task.CompletedTask;
        }
    }
}
