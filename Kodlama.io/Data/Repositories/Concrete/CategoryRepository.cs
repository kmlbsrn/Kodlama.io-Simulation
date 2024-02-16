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
    public class CategoryRepository : ICategoryRepository
    {
        List<CategoryEntity> categories;
        public CategoryRepository()
        {
            
            categories = new List<CategoryEntity>();
           
            categories.Add(new CategoryEntity { Id = 1, Name = "Programlama" });
            categories.Add(new CategoryEntity { Id = 2, Name = "Tasarım" });
            categories.Add(new CategoryEntity { Id = 3, Name = "Yapay Zeka" });
            categories.Add(new CategoryEntity { Id = 4, Name = "Veri Bilimi" });
        }

        public void AddCategory(CategoryEntity category)
        {
           
            categories.Add(category);
        }

        public void DeleteCategory(int id)
        {
            
            categories.Remove(categories.FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<CategoryEntity> GetCategories(Expression<Func<CategoryEntity, bool>> predicate = null)
        {
            
            return predicate == null ? categories : categories.Where(predicate.Compile());

        }

        public void UpdateCategory(CategoryEntity category)
        {
            
            var categoryToUpdate = categories.FirstOrDefault(x => x.Id == category.Id);
            categoryToUpdate.Name = category.Name;

        }
    }
}
