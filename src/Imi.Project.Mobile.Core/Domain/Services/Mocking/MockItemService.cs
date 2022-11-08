using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockItemService
    {
        private readonly ILanguageService _languageService;
        private readonly IGenreService _genreService;
        private readonly IDirectorService _directorService;
        private readonly MockWatchStatus _mockWatchStatus;


        public MockItemService()
        {
            _languageService = new MockLanguageService();
            _genreService = new MockGenreService();
            _directorService = new MockDirectorService();
            _mockWatchStatus = new MockWatchStatus();
        }

        private static List<WatchItem> allItemsList = new List<WatchItem>
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
                },
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
                },

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

        public async Task<IQueryable<WatchItem>> GetWatchItems()
        {
            var items = allItemsList.AsQueryable();
            items.ToList().ForEach(item =>
            {
                item.Language = _languageService.GetLanguageById(item.LanguageId).Result;
                item.Genre = _genreService.GetGenreById(item.GenreId).Result;
                item.WatchStatus = _mockWatchStatus.GetStatusById(item.WatchStatusId).Result.Name;
            });
            return await Task.FromResult(items);
        }

        public async Task<IQueryable<Movie>> GetMovies()
        {
            List<Movie> allMovies = new List<Movie>();
             var items = await GetWatchItems();
            items.ToList();

            foreach(Movie movie in items)
            {
                allMovies.Add(movie);
            }

            var movies = allMovies.AsQueryable();
            movies.ToList().ForEach(movie =>
            {
                movie.Language = _languageService.GetLanguageById(movie.LanguageId).Result;
                movie.Genre = _genreService.GetGenreById(movie.GenreId).Result;
                movie.Director = _directorService.GetDirectorById(movie.DirectorId).Result;
            });
            return await Task.FromResult(movies);
        }
    }
}
