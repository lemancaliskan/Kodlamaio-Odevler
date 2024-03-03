using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Leman";
            var result = sentence.Length; //cümlenin kaç karakterden oluştuğu
            var result2 = sentence.Clone(); //cümlenin bir referansını daha oluşturur, sentence değişse de sonuç değişmez
            sentence = "My name is Dilek"; 

            bool result3= sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name"); //belli bir karakteri veya ifadeyi aramak için
            // var result5 = sentence.IndexOf("nameee");  //bulamadığında -1 döndürür
            var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğu sayar, sonraki boşluklara devam etmez
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, "); //başka bir metni yerleştirmek için
                                                         //0. indexden itibaren "Hello, " ekle.
            var result9 = sentence.Substring(3); //metni parçalamak için
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-"); //belli karakterleri değiştirmek için
            var result13 = sentence.Remove(2,4); //belli bir indexten sonrasını atmak için

            Console.WriteLine("Clone: "+ result2);
            Console.WriteLine("EndsWith: " + result3);
            Console.WriteLine("StartsWith: " + result4);
            Console.WriteLine("IndexOf (name): " + result5);
            Console.WriteLine("IndexOf ( ): " + result6);
            Console.WriteLine("LastIndexOf ( ): " + result7);
            Console.WriteLine("Insert (0, 'Hello, '):  " + result8);
            Console.WriteLine("Substring: "  + result9);
            Console.WriteLine("ToLower: " + result10);
            Console.WriteLine("ToUpper: " + result11);
            Console.WriteLine("Replace: " + result12);
            Console.WriteLine("Remove: " + result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            //stringler birer char array'idir.
            string city = "Ankara";
            //Console.WriteLine(city[0]); //ilk harfi yazar
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2; //stringleri yan yana yazar



            Console.WriteLine(String.Format("{ 0} { 1}", city, city2));
        }
    }
}
