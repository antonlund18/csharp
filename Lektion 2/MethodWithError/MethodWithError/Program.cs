using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithError
{
    class Program
    {

        private void MyMethodWithError(int num = 0)
        {
            throw new Exception("This is an error.");
        }

        public void MyNormalMethod(int num = 0)
        {
            try
            {
                MyMethodWithError();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            } finally
            {
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.MyNormalMethod();
        }
    }
}
