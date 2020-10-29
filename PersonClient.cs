using PersonLibrary;
using System;

namespace PersonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "anna";
            p.LastName = "JANSEN";
            p.Address = "Dorpsstraat 23";
            p.Age = 18;
            //Console.WriteLine($"{p.FirstName}\t{p.LastName}\t{p.Address}\t{p.Age}");
          // Console.WriteLine(p.GetDetails());

            Person q = new Person("BOB","bouw","Kerkstraat 45",34);
            //q.FirstName = "BOB";
            //q.LastName = "bouw";
            //q.Address = "Kerkstraat 45";
            //q.Age = 34;
           // Console.WriteLine(q.GetDetails());

            Person[] personArr = { p, q };
            foreach (var item in personArr)
            {
                Console.WriteLine(item.GetDetails());
            }

        }
    }
}
