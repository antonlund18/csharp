using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Person(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public Person(String info)
        {
            string[] data = info.Split(';');
            Name = data[0];
            Age = int.Parse(data[1]);
            Weight = int.Parse(data[2]);
        }

        public static List<Person> ReadCSVFile(string filename)
        {
            string line;
            List<Person> people = new List<Person>();
            System.IO.StreamReader file = new System.IO.StreamReader(filename);
            while((line = file.ReadLine()) != null)
            {
                Person p = new Person(line);
                people.Add(p);
            }
            file.Close();
            return people;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }

    }
    public class SortByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
    public class SortByWeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Weight - y.Weight;
        }
    }
    public class SortByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
