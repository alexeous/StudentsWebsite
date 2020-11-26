using StudentsWebsite.Core.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly UniversityDbContext dbContext;

        public BaseRepository(UniversityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await SetWithIncludedProperties().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            return SetWithIncludedProperties().FirstOrDefaultAsync(t => t.Id == id);
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

        /// <summary>
        /// The query results will include the properties included in <see cref="IncludeProperties(DbSet{T})"/>
        /// </summary>
        /// <returns></returns>
        protected IQueryable<T> SetWithIncludedProperties()
        {
            return IncludeProperties(dbContext.Set<T>());
        }

        protected virtual IQueryable<T> IncludeProperties(DbSet<T> set)
        {
            return set;
        }
    }
}
