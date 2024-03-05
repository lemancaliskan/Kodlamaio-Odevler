using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
    }

    //*****************************************************************//
    //S — Single-responsibility:
    // Bir sınıfın yalnızca bir sorumluluğu olmalıdır, yani bir sınıfın değişiklik nedeni sadece bir olmalıdır.

    //O — Open-closed:
    //Bir yazılım birim (class, modül, fonksiyon vb.), genişletilmeye açık ancak değişikliğe kapalı olmalıdır,
    //yani yeni özellikler eklemek mümkün olmalı ancak mevcut kodu değiştirmemeli.

    //L — Liskov substitution:
    //Alt sınıflar, üst sınıfların yerine kullanılabilir olmalıdır,
    //yani alt sınıflar, üst sınıfların yerine geçebilmelidir ve beklenen davranışları sergilemelidir.

    //I — Interface segregation:
    //Bir sınıf, ihtiyaç duymadığı methodlara bağlı olmamalıdır;
    //yani bir sınıf, kendi kullanmayacağı arayüz metodlarına sahip olmamalıdır.

    //D — Dependency Inversion:
    //Yüksek seviyeli modüller, düşük seviyeli detaylara bağlı olmamalıdır;
    //her ikisi de soyuta bağlı olmalıdır.

    //*****************************************************************//
    //SOLID -> I-> Interface Segregation
    interface IWorker
    {
        void Work();
       
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {

        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary  //bir class birden fazla interface'i implemente edebilir
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
