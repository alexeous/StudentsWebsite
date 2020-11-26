using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }

        public Task<User> GetByEmailAsync(string email)
        {
            return SetWithIncludedProperties().FirstOrDefaultAsync(user => user.Email == email);
        }
    }
}
