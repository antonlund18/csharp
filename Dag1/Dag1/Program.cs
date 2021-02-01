using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static double Max(params double[] numbers)
        {
            double max = Double.MinValue;
            foreach (double number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            double m1 = Max(28.5, 17.2);
            double m2 = Max(4.0, 10.8, 34.25, 2.0, 23.6);

            Console.WriteLine(m1 + " " + m2);
            Console.ReadLine();
        }
    }
}
