using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(UniversityDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
