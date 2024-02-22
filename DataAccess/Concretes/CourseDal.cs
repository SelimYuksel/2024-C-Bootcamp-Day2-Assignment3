using Day2Assignment3.DataAccess.Abstracts;
using Day2Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment3.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.CourseId = 301;
            course1.CategoryId = 201;
            course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.InstructorId = 101;

            Course course2 = new Course();
            course2.CourseId = 302;
            course2.CategoryId = 201;
            course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
            course2.InstructorId = 101;

            Course course3 = new Course();
            course3.CourseId = 303;
            course3.CategoryId = 201;
            course3.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course3.InstructorId = 101;

            Course course4 = new Course();
            course4.CourseId = 304;
            course4.CategoryId = 201;
            course4.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course4.InstructorId = 101;

            Course course5 = new Course();
            course5.CourseId = 305;
            course5.CategoryId = 201;
            course5.CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)";
            course5.InstructorId = 101;

            Course course6 = new Course();
            course6.CourseId = 306;
            course6.CategoryId = 201;
            course6.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course6.InstructorId = 101;

            Course course7 = new Course();
            course7.CourseId = 307;
            course7.CategoryId = 201;
            course7.CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
            course7.InstructorId = 102;

            Course course8 = new Course();
            course8.CourseId = 308;
            course8.CategoryId = 201;
            course8.CourseName = "Programlama Giriş İçin Temel Kurs";
            course8.InstructorId = 101;
        }


        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {          
            courses.RemoveAll(c => c.CourseId == course.CourseId);       
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            var courseToUpdate = courses.Where(c => c.CourseId == course.CourseId).SingleOrDefault();

            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = course.CourseName;               
            }
            else
            {
                throw new Exception($"Course with ID {course.CourseId} not found.");
            }
        }
    }
}
