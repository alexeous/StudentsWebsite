using StudentsWebsite.Business.Authentication;
using StudentsWebsite.Core.Models;
using StudentsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Security;

namespace StudentsWebsite.Controllers
{
    [Route("api/login")]
    public class LoginApiController : ApiController
    {
        private IAuthenticationService authentication;

        public LoginApiController(IAuthenticationService authentication)
        {
            this.authentication = authentication;
        }

        public async Task<IHttpActionResult> Post([FromBody] LoginModel value)
        {
            if (ModelState.IsValid)
            {
                User user = await authentication.AuthenticateAsync(value.Email, value.Password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, true);
                    return Ok(new { FirstName = user.FirstName, LastName = user.LastName });
                }
                else {
                    return Unauthorized();
                }
            }
            return BadRequest(ModelState);
        }
    }
}