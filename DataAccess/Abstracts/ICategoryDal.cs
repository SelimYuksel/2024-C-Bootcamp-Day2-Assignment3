using Day2Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment3.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);

        void Delete(Category category);

        void Update(Category category);

        List<Category> GetAll();
    }
}
