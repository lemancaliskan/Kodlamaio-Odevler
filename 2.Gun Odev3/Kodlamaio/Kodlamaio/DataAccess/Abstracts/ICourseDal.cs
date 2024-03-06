using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
     interface ICourseDal
    {
        List<Course> GetCourses();
        void AddCourse(Course course);
        void UpdateCourse(int courseId, string updatedCourse);
        void DeleteCourse(int courseId);
    }
}
