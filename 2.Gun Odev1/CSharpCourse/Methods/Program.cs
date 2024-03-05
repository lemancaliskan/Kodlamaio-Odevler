using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            int result = Add2(20, 30);
            var sonuc = Add3(10);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add4(ref number1, number2); //+ref
          

            Console.WriteLine(result2);
            Console.WriteLine(number1); //number1=20 ama ref eklendiğinde number1=30
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Add5(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()  //veri döndüren metot//
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2) //Parametreli metot//
        {
            //return number1 + number2;
            var result = number1 + number2;
            return result;
        }
        static int Add3(int x, int number1 = 20, int number2 = 30) //default parametreli metot//
        {
            var sonuc = number1 + number2;
            return sonuc;
        }
        static int Add4(ref int number1, int number2) //+ref
        {
            number1 = 30;
            return number1 + number2;
        }

        //Ref: Değer tiplerinin referans tip olarak kullanılmasını sağlar.number1'in değerinin olması lazım.
        //Out: Değer tiplerinin referans tip olarak kullanılmasını sağlar.number1'e değer atanmasa da olur.metotun içinde set edilmesi lazım.


        
        static int Multiply(int number1, int number2)
        {
            return number1* number2;
        }
        static int Multiply(int number1, int number2,int number3) //metot overloading//
        {
            int sonuc2= number1 * number2*number3;
            return sonuc2;
        }

        //Params//
        static int Add5(int number, params int[] numbers) //params-> dizi formatında parametre yollamak
                                                          //params-> metotun son parametresi olmak zorunda
        {
            return numbers.Sum(); //dizideki sayıları topla return et
        }
      
    }
  
}
