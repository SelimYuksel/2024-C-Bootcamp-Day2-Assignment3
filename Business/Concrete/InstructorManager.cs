using Day2Assignment3.DataAccess.Abstracts;
using Day2Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment3.Business.Concrete
{
    public class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> GetAll()
        {
            //business rules

            return _instructorDal.GetAll();
        }
    }
}
