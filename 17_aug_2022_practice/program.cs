using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is the addition program in c#");
            int a = 10, b = 20;
            int k = a + b;
            Console.WriteLine("addition of {0} and {1} is {2}",a,b,k);
            int i;
            float radius;
            float pi = 3.14f;
            Console.WriteLine("enter radius");
            radius = Convert.ToSingle(Console.ReadLine());

            double area = pi * radius * radius;
            Console.WriteLine(area);


            //comment---(Select the code to comment)Ctrl+ K+ C
            string name;DateTime bdate;
            Console.WriteLine("Enter a string");
            name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth");
            bdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You entered date as = " + bdate);
            CalculateAge(bdate);
            Console.Read();
        }
        static void CalculateAge(DateTime birthdate)
        {
            int currentDate = DateTime.Now.Year;
            int byear = birthdate.Year;
            int age = currentDate - byear;
            Console.WriteLine("Your age as per your birth date= " + age);

        }
    }
}
