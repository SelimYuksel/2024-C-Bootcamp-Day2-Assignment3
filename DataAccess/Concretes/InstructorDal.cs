using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Assignment3.Entities;
using Day2Assignment3.DataAccess.Abstracts;

namespace Day2Assignment3.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 101;
            instructor1.InstructorName = "Engin Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.InstructorId = 102;
            instructor2.InstructorName = "Halit Enes Kalaycı";
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructors.RemoveAll(c => c.InstructorId == instructor.InstructorId);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            var instructorToUpdate = instructors.Where(c => c.InstructorId == instructor.InstructorId).SingleOrDefault();

            if (instructorToUpdate != null)
            {
                instructorToUpdate.InstructorName = instructor.InstructorName;
            }
            else
            {
                throw new Exception($"Course with ID {instructor.InstructorId} not found.");
            }
        }
    }
}
