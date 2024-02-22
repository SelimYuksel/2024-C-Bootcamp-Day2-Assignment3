using Day2Assignment3.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.Entities;

namespace Day2Assignment3.Business.Concrete
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //business rules

            return _categoryDal.GetAll();
        }
    }
}
