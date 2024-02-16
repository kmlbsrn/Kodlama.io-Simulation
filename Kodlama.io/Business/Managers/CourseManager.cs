using Kodlama.io.Business.Dtos.Course;
using Kodlama.io.Business.Services;
using Kodlama.io.Data.Entities;
using Kodlama.io.Data.Repositories.Abstract;
using Kodlama.io.Data.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Managers
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IInstructorRepository _instructorRepository;

        public CourseManager()
        {

            _courseRepository = new CourseRepository();
            _categoryRepository = new CategoryRepository();
            _instructorRepository = new InstructorRepository();

        }

        public void AddCourse(CourseAddDto course)
        {

            var entity = new CourseEntity
            {
                Name = course.Name,
                Description = course.Description,
                Price = course.Price,
                CategoryId = course.CategoryId,
                InstructorId = course.InstructorId
            };
            _courseRepository.AddCourse(entity);

        }

        public void DeleteCourse(int id)
        {

            _courseRepository.DeleteCourse(id);
        }

        public List<CourseListDto> GetCourses()
        {

            // Retrieve courses, categories, and instructors from repositories
            var courses = _courseRepository.GetCourses();
            var categories = _categoryRepository.GetCategories();
            var instructors = _instructorRepository.GetInstructors();

            // Select courses and map them to CourseListDto
            return courses.Select(x => new CourseListDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                // Retrieve category name using a lookup based on CategoryId
                CategoryName = categories.FirstOrDefault(c => c.Id == x.CategoryId)?.Name,
                // Retrieve instructor name using a lookup based on InstructorId and concatenate first name and surname
                InstructorName = instructors.FirstOrDefault(i => i.Id == x.InstructorId)?.Name + " " + instructors.FirstOrDefault(i => i.Id == x.InstructorId)?.Surname
            }).ToList();


        }

        public void UpdateCourse(CourseUpdateDto course)
        {
            
            var entity = new CourseEntity
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description,
                Price = course.Price,
                CategoryId = course.CategoryId,
                InstructorId = course.InstructorId
            };
            _courseRepository.UpdateCourse(entity);
        }
    }
}
