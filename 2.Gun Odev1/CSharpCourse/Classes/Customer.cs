using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field//
        public string Name;

        //property//
        public int Id { get; set; } //bir müşterinin bilgilerini tutmak içib bir nesne

        //*Eski yazılımlarda kullanılırdı*//
        //private string _firstName;
        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mrs. " + _firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
