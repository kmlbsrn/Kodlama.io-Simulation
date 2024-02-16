using Kodlama.io.Business.Dtos.Category;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }

        public void AddCategory(CategoryAddDto category)
        {
            var entity = new CategoryEntity
            {
                Name = category.Name
            };

            _categoryRepository.AddCategory(entity);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public List<CategoryListDto> GetCategories()
        {
             
            var categories = _categoryRepository.GetCategories();
            return categories.Select(x => new CategoryListDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public void UpdateCategory(CategoryUpdateDto category)
        {
            
            var entity = new CategoryEntity
            {
                Id = category.Id,
                Name = category.Name
            };
            _categoryRepository.UpdateCategory(entity);
        }
    }
}
