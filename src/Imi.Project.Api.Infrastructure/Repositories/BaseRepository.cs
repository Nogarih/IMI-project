using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(t => t.Id.Equals(id));
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {

            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await DeleteAsync(entity);
            return entity;
        }
    }
}