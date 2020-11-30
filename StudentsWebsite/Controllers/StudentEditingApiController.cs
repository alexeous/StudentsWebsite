using StudentsWebsite.Authorization;
using StudentsWebsite.Business.Authorization;
using StudentsWebsite.Business.Editing;
using StudentsWebsite.Core.Models;
using StudentsWebsite.DataAccess.Repositories;
using StudentsWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace StudentsWebsite.Controllers
{
    [CustomAuthorize(Role.Student)]
    [Route("api/editing/student")]
    public class StudentEditingApiController : ApiController
    {
        private IStudentRepository studentRepository;
        private ITeacherRepository teacherRepository;
        private IStudentEditingService editingService;

        public StudentEditingApiController(IStudentRepository studentRepository, ITeacherRepository teacherRepository, IStudentEditingService editingService)
        {
            this.studentRepository = studentRepository;
            this.teacherRepository = teacherRepository;
            this.editingService = editingService;
        }

        public async Task<IHttpActionResult> Get()
        {
            string email = User.Identity.Name;
            Student student = await studentRepository.GetByEmailAsync(email);
            if (student == null)
            {
                return Unauthorized();
            }

            var allTeachers = await teacherRepository.GetAllAsync();
            var editingModel = new StudentEditingModel
            {
                StudentId = student.Id,
                FirstName = student.User.FirstName,
                LastName = student.User.LastName,
                AllTeachers = allTeachers.Select(t => new StudentEditingModel.TeacherInfo
                {
                    Id = t.Id,
                    FirstName = t.User.FirstName,
                    LastName = t.User.LastName,
                    Subject = t.Subject
                }).ToList(),
                VisitedTeacherIds = student.Teachers.Select(t => t.Id).ToList()
            };
            return Ok(editingModel);
        }

        public async Task<IHttpActionResult> Post([FromBody] StudentEditingModel editingModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await editingService.Edit(editingModel.StudentId, editingModel.FirstName,
                        editingModel.LastName, editingModel.VisitedTeacherIds);
                return Ok();
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
        }
    }
}