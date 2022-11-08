﻿using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface ILanguageService 
    {
        Task<IQueryable<Language>> GetLanguagesList();
        Task<Language> GetLanguageById(Guid id);

    }
}
