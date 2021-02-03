using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void calcAge(int birthyear, out int age)
        {
            age = DateTime.Now.Year - birthyear;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthyear:");
            int birthyear = int.Parse(Console.ReadLine());
            int age;
            calcAge(birthyear, out age);
            Console.WriteLine("Your age is: " + age);
            Console.ReadKey();
        }
    }
}
