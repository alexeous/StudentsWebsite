using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess
{
    public static class UniversityDbHelper
    {
        public static void EnsureDatabaseIsCreated()
        {
            using (var dbContext = new UniversityDbContext())
            {
                dbContext.Database.Initialize(true);
            }
        }
    }
}
