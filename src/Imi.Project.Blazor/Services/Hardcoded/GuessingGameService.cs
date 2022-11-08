using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Hardcoded
{
    public class GuessingGameService : IGuessingGameService
    {
        #region seeding
        static List<GameItem> movies = new List<GameItem>
        {
            new GameItem
            {
                Name = "The Prestige",
                Image = "https://m.media-amazon.com/images/M/MV5BODc0MzkxOTg5N15BMl5BanBnXkFtZTcwODkzNDMyMw@@._V1_.jpg"
            },
            new GameItem
            {
                Name = "Logan",
                Image = "https://www.technobuffalo.com/sites/technobuffalo.com/files/styles/large/public/wp/2017/01/logan-trailer-2-024.jpg"
            },
            new GameItem
            {
                Name = "Bullet Train",
                Image = "https://lolalambchops.com/wp/wp-content/uploads/2022/08/Bullet-Train-ok-for-kids.jpg.webp"
            },
            new GameItem
            {
                Name = "Goodfellas",
                Image = "https://faroutmagazine.co.uk/static/uploads/2021/06/The-Goodfellas-1990.jpeg"
            },
            new GameItem
            {
                Name = "The Green Mile",
                Image = "https://img.republicworld.com/republic-prod/stories/promolarge/xhdpi/1cu69uxn6vydpipd_1598028663.jpeg"
            },
            new GameItem
            {
                Name = "Star Wars",
                Image = "https://www.gannett-cdn.com/-mm-/a3e0f4a0ba86914e940648927dc2eab29e2100f8/c=0-88-2962-1761/local/-/media/2015/12/11/USATODAY/USATODAY/635854535689059062-XXX-EMPIRESTRIKESBACK-EP5-KEY-187-R-dcb.JPG?width=660&height=373&fit=crop&format=pjpg&auto=webp"
            },
            new GameItem
            {
                Name = "Gladiator",
                Image = "https://i.ytimg.com/vi/0r1BJcrTzKY/maxresdefault.jpg"
            },
            new GameItem
            {
                Name = "The Usual Suspects ",
                Image = "https://www.slashfilm.com/img/gallery/the-usual-suspects-ending-explained-the-greatest-trick-the-devil-ever-pulled/l-intro-1652535338.jpg"
            },
            new GameItem
            {
                Name = "Alien",
                Image = "https://www.top10films.co.uk/img/ripley-alien-last-scene.jpg"
            },
            new GameItem
            {
                Name = "Memento",
                Image = "https://images.mubicdn.net/images/film/142/cache-32631-1544094102/image-w1280.jpg?size=800x"
            },
            new GameItem
            {
                Name = "Parasite",
                Image = "https://static.standard.co.uk/s3fs-public/thumbnails/image/2019/12/19/12/2a1t0he.jpg?width=968"
            },
            new GameItem
            {
                Name = "Leon",
                Image = "https://thecinemaholic.com/wp-content/uploads/2021/10/Leon.the_.Professional.Extended.1994.720p.BrRip_.x264.YIFY_.mp4_20211002_125039.228.jpg"
            },
            new GameItem
            {
                Name = "Joker",
                Image = "https://www.indiewire.com/wp-content/uploads/2019/10/rev-1-jok-04413_high_res_jpeg_wide-5751b93afee43388b0f06eefd209437871275f92-s800-c85.jpeg"
            },
            new GameItem
            {
                Name = "The Shining",
                Image = "https://miro.medium.com/max/1400/0*GWNUgNnuQs1QB8Se.jpg"
            },
            new GameItem
            {
                Name = "Back To The Future",
                Image = "https://berkshiremuseum.org/wp-content/uploads/2021/09/Back-to-the-Future.jpg"
            },
        };
        #endregion

        public GuessingGameService()
        {
 
        }
        public Task<GameItem> GetRandomMovie()
        {
            GameItem result = new GameItem();
            if (movies.Any())
            {
                var rndm = new Random();
                int index = rndm.Next(1, movies.Count - 1);
        
                try
                {
                    result = movies.ElementAt(index);

                }
                catch
                {
                    result = movies.ElementAt(0);
                }
            }
            return  Task.FromResult(result);
        }
        public Task<bool> CheckMovieGuess(string guess, GameItem movieToGuess)
        {
            if(guess == movieToGuess.Name)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public Task<string> MakeWordSecret(string word)
        {
            string secretWord = "";
            foreach (char c in word)
            {
                if (c == ' ')
                {
                    secretWord += " ";
                }
                else
                {
                    secretWord += "X";
                }
            }

            return Task.FromResult(secretWord);
        }
    }
}
