using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business
{
    class InstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorDal.AddInstructor(instructor);
        }

        public List<Instructor> GetInstructors()
        {
            return _instructorDal.GetInstructors();
        }

        public void UpdateInstructor(int instructorId, string updatedInstructor)
        {
            _instructorDal.UpdateInstructor(instructorId, updatedInstructor);
        }

        public void DeleteInstructor(int instructorId)
        {
            _instructorDal.DeleteInstructor(instructorId);
        }

    }

}
