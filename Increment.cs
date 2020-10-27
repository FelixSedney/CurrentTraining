using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            a=a + 1;
            a += 1;
            a++;//post increment
            ++a;//pre increment

            
            a = 123;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 123;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(a==124);
            int x = 0;
            if (x>0 & b / x > 12) { Console.WriteLine("whatever"); }
        }
    }
}
