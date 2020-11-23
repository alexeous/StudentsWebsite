using StudentsWebsite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    class TeacherRepository : BaseRepository<Teacher>
    {
        public TeacherRepository(UniversityDbContext dbContext) : base(dbContext)
        {
        }
    }
}
