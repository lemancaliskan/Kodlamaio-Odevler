using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes
{
    internal class CourseDal :ICourseDal
    {
        private static List<Course> courses = new List<Course>();

        //Kurs ekleme//
        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Kurs eklendi!");
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        //Kurs güncelleme//
        public void UpdateCourse(int courseId, string updatedCourse)
        {
            Course course = courses.Find(c => c.CourseId == courseId);
            if (course != null)
            {
                course.CourseName = updatedCourse;
                Console.WriteLine("Kurs güncellendi!");
            }
        }

        //Kurs silme//
        public void DeleteCourse(int courseId)
        {
            Course courseToRemove = courses.Find(c => c.CourseId == courseId);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
                Console.WriteLine("Kurs silindi!");
            }
        }
    }
}
