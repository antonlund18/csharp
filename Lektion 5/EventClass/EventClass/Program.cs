using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = EventClass.DelegateUser(EventClass.Abe, "hej");
            Console.WriteLine(length);
            Console.ReadKey();
        }
    }
    class EventClass
    {
        public delegate int StringToInt(string s);
        public static StringToInt Abe = CountChars;

        public static int DelegateUser(StringToInt method, string s)
        {
            return method(s);
        }

        public static int CountChars(string s)
        {
            return s.Length;
        }
    }
}
