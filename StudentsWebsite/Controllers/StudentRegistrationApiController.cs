using StudentsWebsite.Business.Registration;
using StudentsWebsite.Core.Models;
using StudentsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudentsWebsite.Controllers
{
    [Route("api/register/student")]
    public class StudentRegistrationApiController : ApiController
    {
        private IStudentRegistrationService studentRegistration;

        public StudentRegistrationApiController(IStudentRegistrationService studentRegistration)
        {
            this.studentRegistration = studentRegistration;
        }

        public async Task<IHttpActionResult> Post([FromBody] StudentRegistrationModel value)
        {
            if (ModelState.IsValid)
            {
                var student = new Student
                {
                    User = new User
                    {
                        FirstName = value.FirstName,
                        LastName = value.LastName,
                        Email = value.Email,
                        Password = value.Password
                    }
                };
                try
                {
                    await studentRegistration.RegisterAsync(student);
                }
                catch (UserExistsException)
                {
                    return BadRequest("This email address has already been registered.");
                }
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}