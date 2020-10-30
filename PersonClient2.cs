using PersonLibray;
using System;
using System.Collections.Generic;

namespace PersonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("anna","jansen",21,"Kerkstraat 12");
            
            Person q = new Person();
            q.FirstName = "BOB";
            q.LastName = "slager";
            q.Address = "Schoolstraat 23";
            q.Age = 34;


            Student s1 = new Student("VERA", "schilder", 34, "Kortesteeg 45", "Mathematics", 2);
            Student s2 = new Student("ErMa", "TIMMERMAN", 34, "whatever 67", "Databases", 2);
            Student s3 = new Student("Gerard", "MeTsElAaR", 34, "Bloemensteeg 41235", "Development", 2);


            //Person[] personArr = { p, q, new Person("otto", "BaKkEr", 45, "Langestraat 67"),s1,s2,s3 };
            List<Person> personArr = new List<Person>() { p, q, new Person("otto", "BaKkEr", 45, "Langestraat 67"), s1, s2};
            
            personArr.Add(s3);//List<T> is een dynamische collectie waar een array juist statisch
            foreach (var item in personArr)
            {
                Console.WriteLine(item.GetDetails());
            }

            foreach (var item in personArr)
            {
                if (item is Student)//is van het type
                {
                    ((Student)item).Grade += 1;
                }
            }
            Console.WriteLine();
            // Console.WriteLine(p);
            foreach (var item in personArr)
            {
                Console.WriteLine(item.GetDetails());
            }
        }
    }
}
