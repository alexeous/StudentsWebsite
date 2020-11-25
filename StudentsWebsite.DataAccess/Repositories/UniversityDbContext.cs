using StudentsWebsite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    public class UniversityDbContext : DbContext
    {
        private const string ConnectionStringName = "DbConnection";

        static UniversityDbContext()
        {
            // Hack: without this line DLL required by EF may be not present
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public UniversityDbContext() 
            : base(ConnectionStringName)
        {
            Database.SetInitializer(new UniversityDbInitializer());
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
