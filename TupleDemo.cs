using System;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DateNextWeek();
            Console.WriteLine($"next week is {result.d}-{result.m}");
        }

       // return is een tuple
        static  (int d,int m)DateNextWeek()//return the day and the month
        {
            DateTime today = DateTime.Now;
            DateTime result=  today.AddDays(7);
            return (result.Day, result.Month);
        }

    }
}
