using Kodlama.io.Business.Dtos.Instructor;
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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorManager()
        {
            _instructorRepository = new InstructorRepository();
        }

        public void AddInstructor(InstructorAddDto intructor)
        {
            
            var entity = new InstructorEntity
            {
                Name = intructor.FirstName,
                Surname = intructor.LastName
            };

            _instructorRepository.AddInstructor(entity);
        }

        public void DeleteInstructor(int id)
        {
           
            _instructorRepository.DeleteInstructor(id);
        }

        
        public List<InstructorListDto> GetInstructors()
        {
            
            var intructors = _instructorRepository.GetInstructors();
            return intructors.Select(x => new InstructorListDto
            {
                Id = x.Id,
                FirstName = x.Name,
                LastName = x.Surname
            }).ToList();
        }

        public void UpdateInstructor(InstructorUpdateDto intructor)
        {
            throw new NotImplementedException();
        }

        public void UpdateIntructor(InstructorUpdateDto intructor)
        {
            
            var entity = new InstructorEntity
            {
                Id = intructor.Id,
                Name = intructor.FirstName,
                Surname = intructor.LastName
            };
            _instructorRepository.UpdateInstructor(entity);
        }
    }
}
