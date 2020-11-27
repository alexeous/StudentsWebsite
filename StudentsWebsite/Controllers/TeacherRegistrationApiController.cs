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
    [Route("api/register/teacher")]
    public class TeacherRegistrationApiController : ApiController
    {
        private ITeacherRegistrationService teacherRegistration;

        public TeacherRegistrationApiController(ITeacherRegistrationService teacherRegistration)
        {
            this.teacherRegistration = teacherRegistration;
        }

        public async Task<IHttpActionResult> Post([FromBody] TeacherRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var teacher = new Teacher
                {
                    Subject = model.Subject,
                    User = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Password = model.Password
                    }
                };
                try
                {
                    await teacherRegistration.RegisterAsync(teacher, model.SecretWord);
                }
                catch (UserExistsException)
                {
                    return BadRequest("This email address has already been registered.");
                }
                catch (InvalidSecretWordException)
                {
                    return BadRequest("Invalid secret word.");
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