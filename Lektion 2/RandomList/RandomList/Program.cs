using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,15:N0}", rand.Next());
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,15:N0}", rand.NextDouble() * 100);
            }
            Console.ReadKey();
            // NextDouble producerer doubles i stedet for Integers
        }
    }
}
