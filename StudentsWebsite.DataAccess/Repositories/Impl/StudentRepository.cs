using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(UniversityDbContext dbContext) 
            : base(dbContext)
        {
        }

        public Task<Student> GetByUserIdAsync(int userId)
        {
            return SetWithIncludedProperties().FirstOrDefaultAsync(s => s.User.Id == userId);
        }

        public Task<Student> GetByEmailAsync(string email)
        {
            return SetWithIncludedProperties().FirstOrDefaultAsync(s => s.User.Email == email);
        }

        protected override IQueryable<Student> IncludeProperties(DbSet<Student> set)
        {
            return set
                .Include(s => s.User)
                .Include(s => s.Teachers);
        }
    }
}
