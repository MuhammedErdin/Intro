using Intro.Business;
using Intro.DataAccess.Concrete;
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

            CourseManager courseManager = new CourseManager(new EfCourseDal());
            List<Course> courses2=courseManager.GetAll();
            for (int i = 0; i < courses2.Count; i++)
            {
                Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
            }

            Console.WriteLine("Kod Bitti");

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "12345678910";
            customer1.FirstName = "Aslı";
            customer1.LastName = "Karayiğit";
            customer1.CustomerNumber = "123456";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "12345678912";
            customer2.FirstName = "Özgür";
            customer2.LastName = "Atılgan";
            customer2.CustomerNumber = "123457";

            CoorporateCustomer customer3 = new CoorporateCustomer();
            customer3.Id = 3;
            customer3.Name = "Kodlama.io";
            customer3.CustomerNumber = "654778";
            customer3.TaxNumber = "12345678987";

            CoorporateCustomer customer4 = new CoorporateCustomer();
            customer4.Id = 4;
            customer4.Name = "Abc";
            customer4.CustomerNumber = "654779";
            customer4.TaxNumber = "12345678985";


            BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerNumber);
            }
        }
    }
}
