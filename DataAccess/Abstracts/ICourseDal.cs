using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.Entities;

namespace Day2Assignment3.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);

        void Delete(Course course);

        void Update(Course course);

        List<Course> GetAll();
    }
}
