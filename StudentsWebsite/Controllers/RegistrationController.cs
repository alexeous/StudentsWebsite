using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsWebsite.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult RegisterStudent()
        {
            return View();
        }

        public ActionResult RegisterTeacher()
        {
            return View();
        }
    }
}