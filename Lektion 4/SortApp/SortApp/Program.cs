using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    class Program
    {
        public static bool isGreater(int e1, int e2)
        {
            return e1 > e2 ? true : false;
        }
        static void Main(string[] args)
        {
            
            int[] array = { 5, 67, 45, 23, 99, 44, 56, 12, 3, 44 };
            SortingClass.Comparator c = isGreater;
            SortingClass.SortArray(array, c);
            // SortingClass.SortArray(array, (e1, e2) => e1 > e2);
            string s = "";
            foreach (int i in array)
            {
                s += $"{i}, ";
            }
            Console.Write(s.Substring(0, s.Length - 2));
            Console.ReadKey();
        }
    }
}
