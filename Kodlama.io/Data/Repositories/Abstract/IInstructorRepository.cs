using Kodlama.io.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Data.Repositories.Abstract
{
    public interface IInstructorRepository
    {
        IEnumerable<InstructorEntity> GetInstructors(Expression<Func<InstructorEntity, bool>> predicate = null);

        void AddInstructor(InstructorEntity instructor);

        void UpdateInstructor(InstructorEntity instructor);

        void DeleteInstructor(int id);
    }
}
