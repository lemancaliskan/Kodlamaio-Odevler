using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";  
            customer.Id = 1;
            customer.FirstName = "Leman";
            customer.LastName = "Caliskan";

            Customer customer2 = new Customer
            {
                Id = 2, City= "Denizli", FirstName="Jane", LastName="Doe"
            };

            Console.WriteLine(customer2.FirstName); //get//

            Console.ReadLine();
        }
    }
    
   
}
