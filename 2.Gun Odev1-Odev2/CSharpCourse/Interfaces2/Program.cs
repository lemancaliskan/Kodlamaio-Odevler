using System;
using System.ComponentModel;
namespace Interface2
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            //interface-> referans tiptir
            IPersonManager customerManager= new CustomerManager();
            //customerManager.Add();

           IPersonManager employeeManager= new EmployeeManager();  
            
            ProjectManager projectManager= new ProjectManager();
            projectManager.AddCustomer(customerManager);
            projectManager.AddCustomer(new InternManager());

        }
    }

    //class PersonManager
    //{
    //    //implemented operation//
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}
    //class CustomerManager : PersonManager
    //{

    //}
    interface IPersonManager
    {
        //unimplemented operation//
        void Add(); //interface öğeleri dışarıdan erişilebilir olmalıdır.
                    //default public'tir.
        void Update();
    }

    //inherits -> class ********************** implements -> interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları buraya yazılır
            Console.WriteLine("Müşteri eklendi!");
        }

        public void Update()
        {
            //müşteri güncelleme kodları buraya yazılır
            Console.WriteLine("Müşteri güncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları buraya yazılır
            Console.WriteLine("Personel eklendi!");
        }

        public void Update()
        {
            //personel güncelleme kodları buraya yazılır
            Console.WriteLine("Personel güncellendi!");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi!");
        }
    }
    class ProjectManager
    {
        public void AddCustomer(IPersonManager personManager)
        { 
            personManager.Add();

        }
    }
}