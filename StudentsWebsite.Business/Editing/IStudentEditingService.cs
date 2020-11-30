using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWebsite.Business.Editing
{
    public interface IStudentEditingService
    {
        Task EditAsync(int studentId, string firstName, string lastName, ICollection<int> teacherIds);
    }
}
