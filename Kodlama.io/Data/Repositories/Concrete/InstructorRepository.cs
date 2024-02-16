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
    public class InstructorRepository : IInstructorRepository
    {
        List<InstructorEntity> instructors;
        public InstructorRepository()
        {
            instructors = new List<InstructorEntity>
            {
                new InstructorEntity { Id = 1, Name = "Engin", Surname = "Demiroğ" },
                new InstructorEntity { Id = 2, Name = "Kerem", Surname = "Varış" },
                new InstructorEntity { Id = 3, Name = "Berkay", Surname = "Bilgin" },
                new InstructorEntity { Id = 4, Name = "Murat", Surname = "Kurtboğan" },
                new InstructorEntity { Id = 5, Name = "Kaan", Surname = "Kazan" }
            };

        }
        public void AddInstructor(InstructorEntity instructor)
        {
            instructors.Add(instructor);
        }

        public void DeleteInstructor(int id)
        {
           
            instructors.Remove(instructors.FirstOrDefault(x => x.Id == id));
        }

       
        public IEnumerable<InstructorEntity> GetInstructors(Expression<Func<InstructorEntity, bool>> predicate = null)
        {
            return predicate == null ? instructors : instructors.Where(predicate.Compile());
        }

        public void UpdateInstructor(InstructorEntity instructor)
        {
           
            var instructorToUpdate = instructors.FirstOrDefault(x => x.Id == instructor.Id);
            instructorToUpdate.Name = instructor.Name;
            instructorToUpdate.Surname = instructor.Surname;
        }
    }
}
