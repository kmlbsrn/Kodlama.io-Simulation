using Kodlama.io.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Data.Repositories.Abstract
{
    public interface ICourseRepository
    {
        IEnumerable<CourseEntity> GetCourses(Expression<Func<CourseEntity, bool>> predicate = null);

        void AddCourse(CourseEntity course);

        void UpdateCourse(CourseEntity course);

        void DeleteCourse(int id);


    }
}
