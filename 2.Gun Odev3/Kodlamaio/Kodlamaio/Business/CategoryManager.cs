using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business
{
    internal class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.AddCategory(category);
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.GetCategories();
        }
        public void UpdateCategory(int categoryId, string newName)
        {
            _categoryDal.UpdateCategory(categoryId, newName);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryDal.DeleteCategory(categoryId);
        }
    }
}
