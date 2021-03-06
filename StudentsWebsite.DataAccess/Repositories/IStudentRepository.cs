﻿using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetByUserIdAsync(int userId);

        Task<Student> GetByEmailAsync(string email);
    }
}
