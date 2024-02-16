using Kodlama.io.Business.Dtos.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Services
{
    public interface IInstructorService
    {
        List<InstructorListDto> GetInstructors();
        void AddInstructor(InstructorAddDto intructor);
        void UpdateInstructor(InstructorUpdateDto intructor);
        void DeleteInstructor(int id);
    }
}
