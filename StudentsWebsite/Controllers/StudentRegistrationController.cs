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
    public class StudentRegistrationController : ApiController
    {
        public async Task<IHttpActionResult> Post([FromBody] StudentRegistrationModel value)
        {
            if (ModelState.IsValid)
            {
                return Ok(value);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}