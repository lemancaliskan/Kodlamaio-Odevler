using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Leman"},
                new Student{FirstName = "Jane"},
                new Person{FirstName = "John"},
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {

    }

    interface IPerson
    {

    }

    class Customer : Person //customer->çocuk + person->ebeveyn 
    {
        public string City { get; set; }
    }
    class Student : Person, IPerson //sadece bir tane inheritance olabilir.
                                    ///interfaceler fazla olabilir
                                    ///önce inheritance, sonra interface'ler yazılır.
                                    ///classların tek başına anlamı vardır, interface'lerin yoktur
    {
        public string Department { get; set; }
    }
    //Interface'ler inheritance olmasa da inheritance mantığı ile kullanılabilir
}
