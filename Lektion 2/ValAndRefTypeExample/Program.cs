using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            IncrementValue(a);
            Console.WriteLine(a);

            int b = 7;
            IncrementValueByReference(ref b);
            Console.WriteLine(b);

            Console.ReadLine();
        }

        private static void IncrementValueByReference(ref int a)
        {
            a = a + 1;
        }

        private static void IncrementValue(int a)
        {
            a = a + 1;
        }
    }

    class Integer
    {
        public int value;
        
        public Integer(int val)
        {
            value = val;
        }
    }
}
