using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static string fibonacci(string output, int curr, int prev, int upperBound)
        {
            int next = curr + prev;
            if (next > upperBound)
            {
                return output;
            } else if(prev == 0)
            {
                output += "1, " + next;
                return fibonacci(output, next, curr, upperBound);
            }
            {
                output += ", " + next;
                return fibonacci(output, next, curr, upperBound);
            }
        }

        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("Please enter an upper bound integer:");
                string upperBound =  Console.ReadLine();
                int cleanUpperBound = 0;
                while(!int.TryParse(upperBound, out cleanUpperBound))
                {
                    Console.WriteLine("That is not an integer. Try again.");
                    upperBound = Console.ReadLine();
                }
                if(cleanUpperBound == 0)
                {
                    endApp = true;
                    
                } else
                {
                    string output = fibonacci("", 1, 0, cleanUpperBound);
                    Console.WriteLine(output);
                }
            }
            return;
        }
    }
}
