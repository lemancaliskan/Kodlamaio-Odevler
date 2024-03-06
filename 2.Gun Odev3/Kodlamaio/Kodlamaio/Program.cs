using Kodlamaio.Business;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.DataAccess.Concretes;
using Kodlamaio.Entitites;
using System;

class Program
{
    static void Main()
    {
        //Kategori işlemleri//
        ICategoryDal categoryDal = new CategoryDal();
        CategoryManager categoryManager = new CategoryManager(categoryDal);

        Category category1 = new Category { CategoryId = 1, CategoryName = "Programlama" };
        categoryManager.AddCategory(category1);

        categoryManager.UpdateCategory(1, "Programlama");

        //*******************************
        foreach (var category in categoryManager.GetCategories())
        {
            Console.WriteLine("Kategori Id: ", category.CategoryId, "Kategori: ", category.CategoryName);

        }

        categoryManager.DeleteCategory(1);

        Console.WriteLine();

        //Kurs şlemleri
        ICourseDal courseDal = new CourseDal();
        CourseManager courseManager = new CourseManager(courseDal);

        //***************************
        Course course1 = new Course { CourseId = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)" };
        courseManager.AddCourse(course1);

        //********************************
        courseManager.UpdateCourse(1, "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)");

        //*****************************
        foreach (var course in courseManager.GetCourses())
        {
            Console.WriteLine("Kurs ID: ", course.CourseId, "Kurs Adı :" , course.CourseName);
        }

        //*****************************
        courseManager.DeleteCourse(1);

        Console.WriteLine();

        // Instructor işlemleri
        IInstructorDal instructorDal = new InstructorDal();
        InstructorManager instructorManager = new InstructorManager(instructorDal);

        //***********************************
        Instructor instructor1 = new Instructor { InstructorId = 1, InstructorName = "Engin Demiroğ" };
        instructorManager.AddInstructor(instructor1);

        //*************************
        instructorManager.UpdateInstructor(1, "Kodlamaio");

        //****************************
        foreach (var instructor in instructorManager.GetInstructors())
        {
            Console.WriteLine("Eğitmen ID: " , instructor.InstructorId , "Eğitmen: " ,instructor.InstructorName);
        }

        // **************************
        instructorManager.DeleteInstructor(1);
        
        
        Console.ReadLine();
    }

}
