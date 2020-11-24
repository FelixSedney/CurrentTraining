using EFCoreQuerying.DAL;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace EFCoreQuerying
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //exercise2_1();
            //exercise2_2();
            //exercise2_3();
            //exercise2_4();
            //exercise2_5();
            exercise2_6();
            //exercise2_7();
            //exercise2_8();

        }

        private static void exercise2_1()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Person.Where(p => p.HireDate == null);
                foreach (var student in result)
                {
                    Console.WriteLine($"{student.FirstName}\t{student.LastName}");
                }
            }
        }

      

        private static void exercise2_2()
        {
            using (schoolContext context = new schoolContext())
            {
                int skip = 0;
                int take = 3;
                bool hasMoreDate;
                do
                {
                    var result = context.Person.Where(p => p.HireDate == null).Skip(skip).Take(take);
                    Console.WriteLine();
                    foreach (var student in result)
                    {
                        Console.WriteLine($"{student.FirstName}\t{student.LastName}");
                    }
                    hasMoreDate = result.Count() == 3;
                    skip += take;
                    Console.ReadKey();
                }
                while (hasMoreDate);
               
            }
        }

        private static void exercise2_3()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Person.Where(p => p.HireDate == null && p.LastName.StartsWith('A'));
                foreach (var student in result)
                {
                    Console.WriteLine($"{student.FirstName}\t{student.LastName}");
                }
            }
        }

        private static void exercise2_4()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Person.Where(p => p.HireDate == null ).OrderBy(p=>p.LastName);
                foreach (var student in result)
                {
                    Console.WriteLine($"{student.FirstName}\t{student.LastName}");
                }
            }
        }

        private static void exercise2_5()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Course.Include(t=>t.Department);
                foreach (var course in result)
                {
                    Console.WriteLine($"{course.Title}\t{course.Department.Name}");
                }
            }
        }

        private static void exercise2_6()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Course.Include(t => t.Department).AsEnumerable().GroupBy(k=>k.Department);
                foreach (var item in result)
                {
                    Console.WriteLine(item.Key.Name);
                    foreach (var course in item)
                    {
                        Console.WriteLine($"\t{course.Title}");
                    }
                }
            }
        }

        private static void exercise2_7()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.Course.Include(t => t.Department).AsEnumerable().GroupBy(k => k.Department).Where(d=>d.Count()>2);
                foreach (var item in result)
                {
                    Console.WriteLine(item.Key.Name);
                    foreach (var course in item)
                    {
                        Console.WriteLine($"\t{course.Title}");
                    }
                }
            }
        }

        private static void exercise2_8()
        {
            using (schoolContext context = new schoolContext())
            {
                var result = context.OnsiteCourse.Include(t=>t.Course).Include(t=>t.Course.Department);
                foreach (var os_course in result)
                {
                    Console.WriteLine($"{os_course.Course.Title}\t{os_course.Course.Department.Name}\t{os_course.Location}");
                }
            }
        }
    }
}
