using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DbTestPopulator.PopulateDefault().Wait();
            Console.ReadLine();
        }
    }
}
