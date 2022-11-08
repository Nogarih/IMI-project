using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAnimeService 
    {
        Task<IQueryable<Anime>> GetAnimes();
        Task<IQueryable<Anime>> GetAnimesByTitle(string search);
        Task<Anime> GetAnimeDetails(Guid id);
        Task<Anime> UpdateAnime(Anime anime);
        Task<Anime> AddAnime(Anime anime);
        Task<Anime> DeleteAnime(Guid id);
    }
}
