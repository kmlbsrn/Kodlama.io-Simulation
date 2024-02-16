using Kodlama.io.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Data.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryEntity> GetCategories(Expression<Func<CategoryEntity, bool>> predicate = null);

        void AddCategory(CategoryEntity category);

        void UpdateCategory(CategoryEntity category);

        void DeleteCategory(int id);
    }
}
