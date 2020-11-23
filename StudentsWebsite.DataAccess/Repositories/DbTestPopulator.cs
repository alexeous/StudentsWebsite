using StudentsWebsite.Data.Models;
using StudentsWebsite.DataAccess.Repositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.DataAccess.Repositories
{
    public static class DbTestPopulator
    {
        public static async Task PopulateDefault()
        {
            using (var context = new UniversityDbContext())
            {
                var students = new StudentRepository(context);
                var teachers = new TeacherRepository(context);
                var studentsVisitingTeachers = new StudentVisitingTeacherRepository(context);
                var marks = new MarkRepository(context);

                var student1 = new Student { FirstName = "Nick", LastName = "Richards" };
                await students.InsertAsync(student1);

                var student2 = new Student { FirstName = "Maike", LastName = "Schmidt" };
                await students.InsertAsync(student2);


                var teacher1 = new Teacher { FirstName = "Isaac", LastName = "Newton", Subject = "Physics" };
                await teachers.InsertAsync(teacher1);


                var student1visitingTeacher1 = new StudentVisitingTeacher { Student = student1, Teacher = teacher1 };
                await studentsVisitingTeachers.InsertAsync(student1visitingTeacher1);

                var student2visitingTeacher1 = new StudentVisitingTeacher { Student = student2, Teacher = teacher1 };
                await studentsVisitingTeachers.InsertAsync(student2visitingTeacher1);


                var mark1 = new Mark { StudentVisitingTeacher = student1visitingTeacher1, MarkValue = 4 };
                await marks.InsertAsync(mark1);
                var mark2 = new Mark { StudentVisitingTeacher = student1visitingTeacher1, MarkValue = 3 };
                await marks.InsertAsync(mark2);
                var mark3 = new Mark { StudentVisitingTeacher = student2visitingTeacher1, MarkValue = 5 };
                await marks.InsertAsync(mark3);
                var mark4 = new Mark { StudentVisitingTeacher = student2visitingTeacher1, MarkValue = 4 };
                await marks.InsertAsync(mark4);

                context.SaveChanges();
            }
        }
    }
}
