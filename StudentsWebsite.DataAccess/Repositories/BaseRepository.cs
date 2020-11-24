using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private UniversityDbContext dbContext;

        public BaseRepository(UniversityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return dbContext.Set<T>().FindAsync(id);
        }

        public Task InsertAsync(T obj)
        {
            return dbContext.InsertAsync(obj);
        }

        public Task RemoveByIdAsync(int id)
        {
            return dbContext.RemoveAsync<T>(t => t.Id == id);
        }

        public Task UpdateAsync(T obj)
        {
            return dbContext.UpdateAsync(obj, t => t.Id == obj.Id);
        }
    }
}
