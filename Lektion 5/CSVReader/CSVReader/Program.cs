using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public static class ListExt
    {
        public delegate void Update<Person>(Person p);
        public delegate bool Requirements<Person>(Person p);

        public static void UpdatePeople(this List<Person> list, Requirements<Person> reqs, Update<Person> update)
        {
            foreach (Person p in list)
            {
                if (reqs(p))
                {
                    update(p);
                }
            }
        }

        public static void Reset(this List<Person> list)
        {
            foreach(Person p in list)
            {
                p.Accepted = false;
            }
        }
    }

    class Program
    {
        
        public static List<Person> GetPeople(string filename)
        {

            return Person.ReadCSVFile(filename);
        }

        static void Main(string[] args)
        {
            string fileData1 = @"C:\Users\jumme\source\repos\csharp\Lektion 5\CSVReader\data1.csv";
            string fileData2 = @"C:\Users\jumme\source\repos\csharp\Lektion 5\CSVReader\data2.csv";

            List<Person> people = GetPeople(fileData1);

            // Øvelse 1
            // Score below 2
            var list1 = people.FindAll((p) => p.Score < 2);
            // Even score
            var list2 = people.FindAll((p) => p.Score % 2 == 0);
            // Even score and weight > 60
            var list3= people.FindAll((p) => p.Score % 2 == 0 && p.Weight > 60);
            // Weight divisible by 3
            var list4 = people.FindAll((p) => p.Weight % 3 == 0);

            // Øvelse 2
            // First person with a score of 3
            var index1 = people.FindIndex((p) => p.Score == 3);
            // Under 10 years and score of 3
            var index2 = people.FindIndex((p) => p.Score == 3 && p.Age < 10);
            // Count of people under 10 years and score of 3
            var count1 = people.FindAll((p) => p.Score == 3 && p.Age < 10).Count();
            // Under 8 years and score of 3 - Return (-1) meaning person not found
            var index3 = people.FindIndex((p) => p.Score == 3 && p.Age < 8);

            // Øvelse 3
            // Score ascending
            var list5 = GetPeople(fileData1);
            list5.Sort((p1, p2) => p1.Score - p2.Score);
            // Score descending
            var list6 = GetPeople(fileData1);
            list6.Sort((p1, p2) => p2.Score - p1.Score);
            // Age ascending
            var list7 = GetPeople(fileData1);
            list7.Sort((p1, p2) => p1.Age - p2.Age);
            // Age descending
            var list8 = GetPeople(fileData1);
            list8.Sort((p1, p2) => p2.Age - p1.Age);

            // Øvelse 4
            List<Person> list9 = GetPeople(fileData1);
            list9.UpdatePeople(p => p.Score >= 6 && p.Age <= 40, (p) => { p.Accepted = true; });

            // Øvelse 8
            // Sort by score ascending
            var list10 = GetPeople(fileData1);
            var slist10 = from p in list10
                          orderby p.Score
                          select p;

            // Sort by score descending
            var slist11 = from p in list10
                          orderby p.Score descending
                          select p;

            // Sort by age descending
            var slist12 = from p in list10
                          orderby p.Age
                          select p;

            // Sort by age descending
            var slist13 = from p in list10
                          orderby p.Age descending
                          select p;

            // Øvelse 9
            // Sort by distance to avg age
            var dalist = from p in list10
                         let avg = (from p1 in list10
                                    select p1.Age).Average()
                         let dist = Math.Abs(avg - p.Age)
                         orderby dist
                         select new { p.Name, p.Age, dist };

            // Sort people by their Dwa = sqrt(weight^2 + age^2)
            var dwalist = from p in list10
                         let dwa = Math.Sqrt(p.Weight * p.Weight + p.Age * p.Age)
                         orderby dwa
                         select new { p.Name, dwa};

            // Øvelse 13
            var glist = from p in list10
                        orderby p.Name
                        group p by p.Name[0];

            // Øvelse 14
            var list11 = GetPeople(fileData2);
            var elist = from p in list10
                        from p2 in list11
                        where p.Name == p2.Name
                        select p;

            //foreach (var pGroup in glist)
            //{
            //    Console.WriteLine($"{pGroup.Key}:");
            //    foreach(var p in pGroup)
            //    {
            //        Console.WriteLine(p.Name);
            //    }
            //    Console.WriteLine();
            //}

            foreach (var p in elist)
            {
                Console.WriteLine(p);
            }


            Console.ReadKey();
        }
    }
}
