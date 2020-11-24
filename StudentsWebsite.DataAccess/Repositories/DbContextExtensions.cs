using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    static class DbContextExtensions
    {
        public static Task InsertAsync<T>(this DbContext dbContext, T obj) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            
            dbContext.Set<T>().Add(obj);
            return dbContext.SaveChangesAsync();
        }

        public static async Task UpdateAsync<T>(this DbContext dbContext, 
            T obj, 
            Expression<Func<T, bool>> predicate) 
                where T : class
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            var entity = await dbContext.Set<T>().FirstOrDefaultAsync(predicate);
            if (entity != null)
            {
                dbContext.Entry(entity).CurrentValues.SetValues(obj);
                await dbContext.SaveChangesAsync();
            }
        }

        public static async Task RemoveAsync<T>(this DbContext dbContext,
            Expression<Func<T, bool>> predicate)
                where T : class
        {
            var dbSet = dbContext.Set<T>();
            T entity = await dbSet.FirstOrDefaultAsync(predicate);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
