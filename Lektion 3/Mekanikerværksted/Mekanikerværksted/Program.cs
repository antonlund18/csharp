using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekanikerværksted
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }

            public Person(string name, string address)
            {
                Name = name;
                Address = address;
            }

            public virtual int getWeeklyWage()
            {
                return 0;
            }
        }

        public class Mechanic : Person
        {
            public int YearOfApprenticeship { get; set; }
            public int HourlyWage { get; set; }

            public Mechanic(string name, string address, int yearOfApprenticeship, int hourlyWage) : base(name, address)
            {
                YearOfApprenticeship = yearOfApprenticeship;
                HourlyWage = hourlyWage;
            }

            public override int getWeeklyWage()
            {
                return HourlyWage * 37;
            }
        }

        public class Foreman : Mechanic
        {
            public int YearOfForemanship { get; set; }
            public int WeeklyBonus { get; set; }

            public Foreman(string name, string address, int yearOfApprenticeship, int hourlyWage, int yearOfForemanship, int weekkyBonus)
                : base(name, address, yearOfApprenticeship, hourlyWage)
            {
                YearOfForemanship = yearOfForemanship;
                WeeklyBonus = weekkyBonus;
            }

            public override int getWeeklyWage()
            {
                return base.getWeeklyWage() + WeeklyBonus;
            }
        }

        public class Inspector : Mechanic
        {
            public int NumberOfInspections { get; set; }
            public int WeeklyWage
            {
                get { return NumberOfInspections * 290; }
                set { WeeklyWage = value; }
            }

            public Inspector(string name, string address, int yearOfApprenticeship, int numberOfInspections) : base(name, address, yearOfApprenticeship, 0)
            {
                NumberOfInspections = numberOfInspections;
            }

            public override int getWeeklyWage()
            {
                return WeeklyWage;
            }
        }

        static void Main(string[] args)
        {
            Person p = new Person("Anton", "Frederiksgade");
            Mechanic m = new Mechanic("Per", "Rosenkrantzgade", 2005, 200);
            Foreman f = new Foreman("Svend", "Jerichausgade", 2004, 300, 2008, 1000);
            Inspector i = new Inspector("Bo", "Jægergårdsgade", 2003, 10);

            p.Name = "Anders";
            m.Address = "Skolegade";
            f.YearOfApprenticeship = 2002;
            i.NumberOfInspections = 20;

            Console.WriteLine(p.Name); // Expected 'Anders'
            Console.WriteLine(m.Address); // Expected 'Skolegade'
            Console.WriteLine(f.YearOfApprenticeship); // Expected '2002'
            Console.WriteLine(i.NumberOfInspections); // Expected '20'
            Console.WriteLine();

            List<Person> persons = new List<Person>();
            persons.Add(p);
            persons.Add(m);
            persons.Add(f);
            persons.Add(i);
            foreach(Person person in persons)
            {
                Console.WriteLine(person.getWeeklyWage());
            }

            Console.ReadKey();
        }
    }
}
