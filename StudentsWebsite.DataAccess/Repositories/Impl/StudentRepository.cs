﻿using StudentsWebsite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories.Impl
{
    class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(UniversityDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
