using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.DataAccess.Concretes;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Kodlamaio.Business
{
    class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            _courseDal.AddCourse(course);
        }

        public List<Course> GetCourses()
        {
            return _courseDal.GetCourses();
        }
        public void UpdateCourse(int courseId, string updatedCourse)
        {
            _courseDal.UpdateCourse(courseId, updatedCourse);
        }

        public void DeleteCourse(int courseId)
        {
            _courseDal.DeleteCourse(courseId);
        }
    } 
}
