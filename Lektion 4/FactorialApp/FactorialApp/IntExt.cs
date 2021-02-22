using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp
{
    public static class IntExt
    {
        public static int factorial(this int n)
        {
            if(n == 0)
            {
                return 1;
            } else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
