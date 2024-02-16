using Kodlama.io.Data.Entities;
using Kodlama.io.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Data.Repositories.Concrete
{
    public class CourseRepository : ICourseRepository
    {
        List<CourseEntity> courses;
        public CourseRepository()
        {
           courses= new List<CourseEntity>
           {
                new CourseEntity
                {
                    Id=1,
                    Name="C#",
                    Description="C# Dersleri",
                    Price=100,
                    CategoryId=1,
                    InstructorId=1
                },
                new CourseEntity
                {
                    Id=2,
                    Name="Java",
                    Description="Java Dersleri",
                    Price=200,
                    CategoryId=1,
                    InstructorId=2
                },
                new CourseEntity
                {
                    Id=3,
                    Name="Python",
                    Description="Python Dersleri",
                    Price=300,
                    CategoryId=1,
                    InstructorId=3
                }
            };
        }
        public void AddCourse(CourseEntity course)
        {

           courses.Add(course);
            

        }

        public void DeleteCourse(int id)
        {
            courses.Remove(courses.FirstOrDefault(x => x.Id == id));
        }


        public IEnumerable<CourseEntity> GetCourses(Expression<Func<CourseEntity, bool>> predicate = null)
        {
            
            return predicate == null ? courses : courses.Where(predicate.Compile());
        }

        public void UpdateCourse(CourseEntity course)
        {
            
            var courseToUpdate = courses.FirstOrDefault(x => x.Id == course.Id);
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.Price = course.Price;

        }
    }
}
