using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.Entities;
using Day2Assignment3.DataAccess.Abstracts;

namespace Day2Assignment3.Business.Concrete
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            //business rules

            return _courseDal.GetAll();
        }
    }
}
