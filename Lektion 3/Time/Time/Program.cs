using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        struct Time
        {
            private int seconds;
            public int Hour { get; set; }
            public int Min { get; set; }
            public int Sec { get; set; }

            public Time(string time)
            {
                Hour = Int32.Parse(time.Substring(0, 2));
                Min = Int32.Parse(time.Substring(3, 2));
                Sec = Int32.Parse(time.Substring(6, 2));
                seconds = Sec + Min * 60 + Hour * 60 * 60;
            }
            public Time(int hour, int min, int sec)
            {
                Hour = hour;
                Min = min;
                Sec = sec;
                seconds = Sec + Min * 60 + Hour * 60 * 60;
            }

            public int getSeconds()
            {
                return seconds;
            }

            public override string ToString()
            {
                return $"{Hour}:{Min}:{Sec}";
            }
        }
        static void Main(string[] args)
        {
            Time t1 = new Time("01:23:20");
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t1.getSeconds());

            Time t2 = new Time(11, 23, 20);
            Console.WriteLine(t2.ToString());
            Console.WriteLine(t2.getSeconds());
            Console.ReadKey();
        }
    }
}
