using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using StudentsWebsite.DataAccess.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StudentsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<ActionResult> Index()
        {
            return View(await studentRepository.GetAllAsync());
        }
    }
}