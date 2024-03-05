using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        //C#'da daha çok for ve foreach döngüleri kullanılır
        {
            //sayac   //şart  //+2 arttır
            //ForLoop();   ->  For döngsü "Refactor" ile metot haline dönüştürüldü
            //WhileLoop();
            //DoWhile();
            //ForEach();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This isn't a prime number");
            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i<number-1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        

        private static void ForEach()
        {
            //foreach bir veritabanında datayı gezmek için kullanılır
            string[] students = new string[3] { "Deniz", "Derin", "Derya" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhile()
        {
            //do while sıklıkla kullanılan bir döngü değildir
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0) //belli bir şart sağlanana kadar döngü çalışıp durur
            {
                Console.WriteLine(number);
                number--; //sayıyı -1 azalt.
            }

            Console.WriteLine(" Now number is {0}", number);
            
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)   //i=i+2 == i+=2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }
    }
}
