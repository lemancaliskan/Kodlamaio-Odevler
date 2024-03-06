using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts
{
    internal interface IInstructorDal
    {
        List<Instructor> GetInstructors();
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(int instructorId, string updatedInstructor);
        void DeleteInstructor(int instructorId);
    }
}
