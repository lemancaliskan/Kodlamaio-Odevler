using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes
{
    internal class InstructorDal : IInstructorDal
    {
        private static List<Instructor> instructors = new List<Instructor>();

        //eğitmen ekleme//
        public void AddInstructor(Instructor instructor)
        {
            instructors.Add(instructor);
            Console.WriteLine("Eğitmen eklendi!");
        }

        public List<Instructor> GetInstructors()
        {
            return instructors;
        }

        //eğitmen güncelleme//
        public void UpdateInstructor(int instructorId, string updatedInstructor)
        {
            Instructor instructor = instructors.Find(i => i.InstructorId == instructorId);
            if (instructor != null)
            {
                instructor.InstructorName = updatedInstructor;
                Console.WriteLine("Eğitmen güncellendi!");
            }
        }

        //eğitmen silme//
        public void DeleteInstructor(int instructorId)
        {
            Instructor instructorToRemove = instructors.Find(i => i.InstructorId == instructorId);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
                Console.WriteLine("Eğitmen silndi!");
            }

        }
    }
}

