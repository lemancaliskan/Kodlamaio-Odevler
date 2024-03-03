using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tek boyutlu dizi//
            string[] students = new string[3];
            students[0] = "Deniz";
            students[1] = "Derin";
            students[2] = "Derya";

            string[] students2 = new[] { "Deniz", "Derin", "Derya" };

            string[] students3 = new string [3] { "Deniz", "Derin", "Derya" };

            foreach (var student in students) //foreach-> array'i gezmek için kullanılır
            {
                Console.WriteLine(student);
            }

            //çok boyutlu dizi//

            string[,] regions = new string[5,3]
            {
                {"İstanbul","İzmit","Balıkesir "},
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Denizli" },

            };
            
            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*******************");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
