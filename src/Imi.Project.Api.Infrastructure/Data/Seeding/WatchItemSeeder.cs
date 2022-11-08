using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class WatchItemSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region Anime seeding
            modelBuilder.Entity<Anime>().HasData(
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "My Hero Academia",
                    ReleaseYear = 2016,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "A superhero-loving boy without any powers is determined to enroll in a prestigious hero academy and learn what it really means to be a hero.",
                    Image = "https://static.posters.cz/image/750/posters/my-hero-academia-cobalt-blast-group-i63331.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Seasons = 5,
                    TotalEpisodes = 117,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Jujutsu Kaisen",
                    ReleaseYear = 2020,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "A boy swallows a cursed talisman - the finger of a demon - and becomes cursed himself. He enters a shaman's school to be able to locate the demon's other body parts and thus exorcise himself.",
                    Image = "https://www.themoviedb.org/t/p/original/mJVUZpPR4BdZzLWyP51h8pOU1RO.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Seasons = 1,
                    TotalEpisodes = 24,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Bleach",
                    ReleaseYear = 2004,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "High school student Ichigo Kurosaki, who has the ability to see ghosts, gains soul reaper powers from Rukia Kuchiki and sets out to save the world from Hollows.",
                    Image = "https://pics.filmaffinity.com/Bleach_TV_Series-214857327-large.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Seasons = 16,
                    TotalEpisodes = 369,
                    HasSub = false
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "Death Note",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.",
                    Image = "https://m.media-amazon.com/images/I/716ASj7z2GL._AC_SL1000_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Seasons = 1,
                    TotalEpisodes = 37,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Dragon Ball Z",
                    ReleaseYear = 1996,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "After learning that he is from another planet, a warrior named Goku and his friends are prompted to defend it from an onslaught of extraterrestrial enemies.",
                    Image = "https://m.media-amazon.com/images/M/MV5BMGMyOThiMGUtYmFmZi00YWM0LWJiM2QtZGMwM2Q2ODE4MzhhXkEyXkFqcGdeQXVyMjc2Nzg5OTQ@._V1_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Seasons = 16,
                    TotalEpisodes = 227,
                    HasSub = false
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Naruto",
                    ReleaseYear = 2007,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "Naruto Uzumaki, is a loud, hyperactive, adolescent ninja who constantly searches for approval and recognition, as well as to become Hokage, who is acknowledged as the leader and strongest of all ninja in the village.",
                    Image = "https://www.ecranlarge.com/uploads/image/001/151/affiche-1151327.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Seasons = 21,
                    TotalEpisodes = 502,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "Kaichou wa Maid-sama!",
                    ReleaseYear = 2010,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "Ayuzawa Misaki serves as the student council president at Seika High. However, unbeknownst to her classmates, she works part-time as an employee at a Maid Cafe. Usui Takumi, a boy from her school, discovers this secret.",
                    Image = "https://www.themoviedb.org/t/p/original/igkn0M1bgMeATz59LShvVxZNdVd.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    Seasons = 1,
                    TotalEpisodes = 28,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Shingeki no Kyojin",
                    ReleaseYear = 2013,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "After his hometown is destroyed and his mother is killed, young Eren Jaeger vows to cleanse the earth of the giant humanoid Titans that have brought humanity to the brink of extinction.",
                    Image = "https://cdn.europosters.eu/image/750/posters/attack-on-titan-shingeki-no-kyojin-key-art-i22808.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Seasons = 4,
                    TotalEpisodes = 86,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "Gintama",
                    ReleaseYear = 2005,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "In an era where aliens have invaded and taken over feudal Tokyo, an unemployed samurai finds work however he can.",
                    Image = "https://www.themoviedb.org/t/p/w500/5AX6ObPYZN0RP3L0Eu7s0RCLxeX.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Seasons = 8,
                    TotalEpisodes = 375,
                    HasSub = true
                },
                new Anime
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Fruits Basket",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "After Tohru is taken in by the Soma family, she learns that twelve family members transform involuntarily into animals of the Chinese zodiac and helps them deal with the emotional pain caused by the transformations.",
                    Image = "https://image.animedigitalnetwork.fr/license/fruitsbasket/tv/web/affiche_370x0.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    Seasons = 5,
                    TotalEpisodes = 63,
                    HasSub = true
                }
                );
            #endregion
            #region Movie seeding
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Title = "Joker",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.",
                    Image = "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/608x608/products/89058/93685/Joker-2019-Final-Style-steps-Poster-buy-original-movie-posters-at-starstills__62518.1572351179.jpg?c=2",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Title = "Law Abiding Citizen",
                    ReleaseYear = 2009,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free.",
                    Image = "https://i.pinimg.com/originals/98/53/97/985397db12c9ee1e9a6f1887132d7143.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Title = "Logan",
                    ReleaseYear = 2017,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.",
                    Image = "https://m.media-amazon.com/images/I/91WgnhSHyzL._AC_SL1500_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Title = "The Prestige",
                    ReleaseYear = 2006,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",
                    Image = "https://i.pinimg.com/originals/b8/ca/36/b8ca36698e80e2e5b8da7ac5311dea68.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    Title = "Your Name",
                    ReleaseYear = 2016,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Description = "Two strangers find themselves linked in a bizarre way. When a connection forms, will distance be the only thing to keep them apart?",
                    Image = "https://cdn.hmv.com/r/w-640/hmv/files/7e/7e218362-fccb-4eea-9d9a-f8df684538ec.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
                    Title = "Tarzan",
                    ReleaseYear = 1999,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A man raised by gorillas must decide where he really belongs when he discovers he is a human.",
                    Image = "https://m.media-amazon.com/images/I/511JYaL4kAL._AC_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
                    Title = "The Thing",
                    ReleaseYear = 1982,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.",
                    Image = "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
                    Title = "Gladiator",
                    ReleaseYear = 2000,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                    Image = "https://lh3.googleusercontent.com/proxy/Urw2HIVZ39hfNxch37mGggoOCjTsUlncvcSO1W5fwAcXO3CzMIlRzZHN_By1QEHCuG6ETpP5lF-ZVUOatxTM_hAu6ub9bT0ovDE_oOww7XfWfKak",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
                    Title = "The Last Duel",
                    ReleaseYear = 2021,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "King Charles VI declares that Knight Jean de Carrouges settle his dispute with his squire by challenging him to a duel.",
                    Image = "https://lh3.googleusercontent.com/proxy/8Jbnz5trqlL0vTp5gazZ_r8zE3PCniCJkolTQgsW7X0Q5mniaV02QKhkrI0Zq7M9VKWLlNHai28fa1PMQVyT2z-yRVi0xmVbbygndelZ1cs",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                },
                new Movie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
                    Title = "Parasite",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    Image = "https://m.media-amazon.com/images/I/91sustfojBL._AC_SL1500_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    DirectorId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                }
                );
            #endregion
            #region TvSerie seeding
            modelBuilder.Entity<TvSerie>().HasData(
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
                    Title = "Dexter",
                    ReleaseYear = 2006,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "He's smart. He's lovable. He's Dexter Morgan, America's favorite serial killer, who spends his days solving crimes and nights committing them. Golden Globe winner Michael C. Hall stars in the hit SHOWTIME Original Series.",
                    Image = "https://m.media-amazon.com/images/I/71OC--Zwi2L._AC_SL1000_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Seasons = 8,
                    TotalEpisodes = 96
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
                    Title = "Deadwood",
                    ReleaseYear = 2004,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A show set in the late 1800s, revolving around the characters of Deadwood, South Dakota; a town of deep corruption and crime.",
                    Image = "https://m.media-amazon.com/images/I/918wMqktUNL._SY500_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Seasons = 3,
                    TotalEpisodes = 36,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
                    Title = "Breaking Bad",
                    ReleaseYear = 2008,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    Image = "https://i.pinimg.com/originals/72/83/92/728392b482329cfef27833fe110321b8.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Seasons = 5,
                    TotalEpisodes = 62,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
                    Title = "The Boys",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A group of vigilantes set out to take down corrupt superheroes who abuse their superpowers.",
                    Image = "https://m.media-amazon.com/images/M/MV5BNGEyOGJiNWEtMTgwMi00ODU4LTlkMjItZWI4NjFmMzgxZGY2XkEyXkFqcGdeQXVyNjcyNjcyMzQ@._V1_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Seasons = 2,
                    TotalEpisodes = 24,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000025"),
                    Title = "Invincible",
                    ReleaseYear = 2021,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "An adult animated series based on the Skybound/Image comic about a teenager whose father is the most powerful superhero on the planet.",
                    Image = "https://m.media-amazon.com/images/M/MV5BNWYwYjAyMzgtNzQyNC00M2JiLWI2ZTQtNzRmZThmOTk4NmRmXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    Seasons = 1,
                    TotalEpisodes = 8,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000026"),
                    Title = "Californication",
                    ReleaseYear = 2007,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A writer tries to juggle his career, his relationship with his daughter and his ex-girlfriend, as well as his appetite for beautiful women.",
                    Image = "https://www.themoviedb.org/t/p/original/jPqOY8cq9KXQN4bD7zJGHCNvcb4.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Seasons = 7,
                    TotalEpisodes = 84,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000027"),
                    Title = "The Witcher",
                    ReleaseYear = 2019,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "Geralt of Rivia, a solitary monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.",
                    Image = "https://m.media-amazon.com/images/I/713TM23V+CL._AC_SL1000_.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Seasons = 1,
                    TotalEpisodes = 17,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    Title = "Squid Game",
                    ReleaseYear = 2021,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Description = "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes. A survival game that has a whopping 45.6 billion-won prize at stake.",
                    Image = "https://0.soompi.io/wp-content/uploads/2021/08/23110511/squid-game.jpeg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Seasons = 1,
                    TotalEpisodes = 9,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000029"),
                    Title = "Avatar: The Last Airbender",
                    ReleaseYear = 2005,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/81KjBiKs-AL.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000028"),
                    Seasons = 3,
                    TotalEpisodes = 62,
                },
                new TvSerie
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000030"),
                    Title = "Peaky Blinders",
                    ReleaseYear = 2014,
                    LanguageId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Description = "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.",
                    Image = "https://i.pinimg.com/originals/b7/7c/ec/b77cec7281be7c2fc1dd793362927f76.jpg",
                    GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Seasons = 5,
                    TotalEpisodes = 36,
                }
                );
            #endregion
        }
    }
}