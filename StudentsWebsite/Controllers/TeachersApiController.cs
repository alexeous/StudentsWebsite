using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace StudentsWebsite.Controllers
{
    [Route("api/teachers")]
    public class TeachersApiController : ApiController
    {
        private ITeacherRepository teacherRepository;

        public TeachersApiController(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public Task<IEnumerable<Teacher>> Get()
        {
            return teacherRepository.GetAllAsync();
        }
    }
}