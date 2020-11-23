using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
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

        public Task InsertAsync(T obj)
        {
            dbContext.Set<T>().Add(obj);
            return dbContext.SaveChangesAsync();
        }
    }
}
