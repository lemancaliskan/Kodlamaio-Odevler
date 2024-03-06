using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
     interface ICategoryDal
    {
        List<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(int categoryId, string updatedName);
        void DeleteCategory(int categoryId);
    }
}
