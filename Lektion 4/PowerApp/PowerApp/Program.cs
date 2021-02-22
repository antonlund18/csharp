using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(4.Power(3));
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
