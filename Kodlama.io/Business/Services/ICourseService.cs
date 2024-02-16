using Kodlama.io.Business.Dtos.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Services
{
    public interface ICourseService
    {
        List<CourseListDto> GetCourses();
        void AddCourse(CourseAddDto course);
        void UpdateCourse(CourseUpdateDto course);
        void DeleteCourse(int id);

    }
}
