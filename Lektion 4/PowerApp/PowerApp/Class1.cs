using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp
{
    public static class IntExt
    {
        public static int Power(this int n, int p)
        {
            if(p > 0)
            {
                return n * Power(n, p - 1);
            } else if (p == 0)
            {
                return 1;
            } else
            {
                throw new Exception("Power must be greater than 0.");
            }
        }
    }
}
