using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.Entities;

namespace Day2Assignment3.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);

        void Delete(Instructor instructor);

        void Update(Instructor instructor);

        List<Instructor> GetAll();

    }
}
