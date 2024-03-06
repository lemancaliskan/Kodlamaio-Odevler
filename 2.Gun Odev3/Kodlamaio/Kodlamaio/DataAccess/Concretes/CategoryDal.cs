using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes
{
     class CategoryDal : ICategoryDal
    {
        private static List<Category> categories = new List<Category>();

        //Kategori ekleme//
        public void AddCategory(Category category)
        {
            categories.Add(category);
            Console.WriteLine("Kategori eklendi!");
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        //Kategori güncelleme//
        public void UpdateCategory(int categoryId, string updatedName)
        {
            Category category = categories.Find(c => c.CategoryId == categoryId);
            if (category != null)
            {
                category.CategoryName = updatedName;
                Console.WriteLine("Kategori silindi!");
            }
        }

        //Kategori silme//
        public void DeleteCategory(int categoryId)
        {
            Category categoryToRemove = categories.Find(c => c.CategoryId == categoryId);
            if (categoryToRemove != null)
            {
                categories.Remove(categoryToRemove);
                Console.WriteLine("Kategori güncellendi!");
            }
        }
    }
}
