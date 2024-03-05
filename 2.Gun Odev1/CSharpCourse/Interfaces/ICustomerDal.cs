using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal //Dal-> Data Access Layer
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal  //polimorfizm örneği
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }
    }
    class OracleServerCustomerDal : ICustomerDal  //polimorfizm örneği
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!"); ;
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
