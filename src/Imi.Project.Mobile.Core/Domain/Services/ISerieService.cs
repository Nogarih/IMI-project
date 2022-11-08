using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface ISerieService
    {
        Task<IQueryable<Serie>> GetSeries();
        Task<IQueryable<Serie>> GetSeriesByTitle(string search);
        Task<Serie> GetSerieDetails(Guid id);
        Task<Serie> UpdateSerie(Serie serie);
        Task<Serie> AddSerie(Serie serie);
        Task<Serie> DeleteSerie(Guid id);
    }
}
