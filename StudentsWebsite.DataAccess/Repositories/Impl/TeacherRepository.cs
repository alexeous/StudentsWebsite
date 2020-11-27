using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Teacher> GetByUserIdAsync(int userId)
        {
            return SetWithIncludedProperties().FirstOrDefaultAsync(t => t.User.Id == userId);
        }

        protected override IQueryable<Teacher> IncludeProperties(DbSet<Teacher> set)
        {
            return set.Include(t => t.User);
        }
    }
}
