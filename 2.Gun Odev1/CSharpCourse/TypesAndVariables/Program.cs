using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char character = 'a';
            string city = "Ankara";
            bool condition = false; // bool: true - false
            byte number4 = 0; // byte: 0 -> 255
            short number3 = -32768; // short: -32768 -> 32767
            int number1 = 10; // int: -2147483648 -> 2147483647 
            long number2 = 2147483647; // long: -9223372036854775808 -> 9223372036854775807
            double number5 = 10.4; // double: ondalıklı sayı
            decimal number6 = 10.4m; // decimal: ondalıklı sayı. m / M
            var number7 = 10; 


            Console.WriteLine("Number 1 is {0} ", number1);
            Console.WriteLine("Number 2 is {0} ", number2);
            Console.WriteLine("Number 3 is {0} ", number3);
            Console.WriteLine("Number 4 is {0} ", number4);
            Console.WriteLine("Number 5 is {0} ", number5);
            Console.WriteLine("Number 6 is {0} ", number6);
            Console.WriteLine("Number 7 is {0} ", number6);
            Console.WriteLine("Condition is {0} ", condition);
            Console.WriteLine("Character is {0} ", (int) character);
            Console.WriteLine("City is {0} ", city);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10, Tuesday=20, Wednesday, Friday, Saturday, Sunday
    }
}
