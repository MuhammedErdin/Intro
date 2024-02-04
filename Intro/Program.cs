using Intro.Business;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Krediler";
            int term = 12;
            double amount = 100000;

            bool isAuthenticated = false;
            Console.WriteLine(message1);

            if (isAuthenticated==true)
            {
                Console.WriteLine("Hoşgeldin Engin");
            }
            else
            {
                Console.WriteLine("Sisteme giriş yap");
            }

            string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };
            //string[] loans2 = new string[6];
            //loans2[0] = "Kredi1";
            //loans2[1] = "Kredi2";

            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }
            //Course course1 = new Course();
            //course1.Id = 1;
            //course1.Name = "C#";
            //course1.Description = ".NET 8 vs...";
            //course1.Price = 0;

            //Course course2 = new Course();
            //course2.Id = 2;
            //course2.Name = "Java";
            //course2.Description = "Java 17 ....";
            //course2.Price = 10;

            //Course course3 = new Course();
            //course3.Id = 3;
            //course3.Name = "Python";
            //course3.Description = "Python 3.12 ...";
            //course3.Price = 20;

            //Course[] courses = { course1, course2, course3 };

            //for (int i = 0; i < courses.Length; i++)
            //{
            //    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
            //}

            CourseManager courseManager = new CourseManager();
            Course[] courses2=courseManager.GetAll();
            for (int i = 0; i < courses2.Length; i++)
            {
                Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
            }

            Console.WriteLine("Kod Bitti");
        }
    }
}
