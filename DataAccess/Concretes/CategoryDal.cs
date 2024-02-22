using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.DataAccess.Abstracts;
using Day2Assignment3.Entities;

namespace Day2Assignment3.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;

        public CategoryDal()
        {
            Category category1 = new Category();
            category1.CategoryId = 201;
            category1.CategoryName = "Programlama";
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.RemoveAll(c => c.CategoryId == category.CategoryId);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            var categoryToUpdate = categories.Where(c => c.CategoryId == category.CategoryId).SingleOrDefault();

            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
            }
            else
            {
                throw new Exception($"Course with ID {category.CategoryId} not found.");
            }
        }
    }
}
