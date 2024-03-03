using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            //Polimorfizm: çok biçimlilik ->
            //bir nesneyi farklı amaçlarla implemente edip, o implementationların tamamına ya da bir kısmına ulaşmak.

            ICustomerDal[] customerDals = new ICustomerDal[2]
                {
                    new SqlServerCustomerDal(),      
                    new OracleServerCustomerDal(),
                };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            //bir Interface hiçbir zaman new'lenemez. --> IPerson person = new IPerson();
            //Interface'ler katmanlar arası geçişlerde kullanılır.





            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer { Id = 1, FirstName = "Leman", LastName = "Caliskan", Address = "Denizli" });

            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Leman",
                LastName = "Caliskan",
                Address = "Denizli"
            };
            manager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe",
                Department = "Medicine"
            };
            manager.Add(student);
        }
    }
    interface IPerson //interface büyük I ile başlar ->IPerson
                      //interface -> soyut nesne + //class -> somut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer: IPerson  //IPerson'da tanımlanan her şey burada da görünür
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
