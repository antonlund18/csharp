using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\jumme\source\repos\csharp\Lektion 4\CSVReader\data.csv";
            var people = Person.ReadCSVFile(filename);
            Console.WriteLine("Number of people in data file: " + people.Count());
            people.Sort(new SortByAge());
            foreach(Person p in people) {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
