using System;
namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean -->value types (değer tipler) --> stack'te
            int sayi1 = 10;
            int sayi2= 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1: "+ sayi1);

            //array, class, interface -->reference types --> heap'te
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1=sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar 1: " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Leman";

            person2 = person1;   //adres eşitleme
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Jane";
            Employee employee = new Employee();

            // customer = employee; -/customer'a employee atanamaz.

            Person person3 = customer;  //base class'a onu inherite eden sınıfların referansı atanabilir
            customer.FirstName = "John";
            customer.CreditCardNumber = 1234567899;

            Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer) person3).CreditCardNumber); //boxing//

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);


        }
    }

    class Person  //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    
    class PersonManager
    {
        public void Add(Person person) //Person-> person, customer, employee gönderilebilir
        {
            Console.WriteLine(person.FirstName);
        }
    }
}