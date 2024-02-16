using Kodlama.io.Business.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business.Services
{
    public interface ICategoryService
    {
        List<CategoryListDto> GetCategories();
        void AddCategory(CategoryAddDto category);
        void UpdateCategory(CategoryUpdateDto category);
        void DeleteCategory(int id);

    }
}
