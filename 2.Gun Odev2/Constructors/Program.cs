using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor (yapıcı blok) -> bir class'ı new'lediğimiz zaman çalışan bloktur.
            Customer customer = new Customer { Id = 1, FirstName = "Leman", LastName = "Caliskan", City = "Denizli" };
            
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Jane", "Doe", "New York");
            
            Console.WriteLine(customer2.FirstName);




        }
      
    }


    class Customer
    {
        //default constructor//
        public Customer() //->parametre verilmeyen ->customer
        {
            
        }
        
        public Customer(int id, string firstName, string lastName, string city) //-> parametre verilen ->customer2
        {                              //metot parametreleri camelCase yazılır 
            Id = id;
            FirstName = firstName; 
            LastName = lastName; 
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}