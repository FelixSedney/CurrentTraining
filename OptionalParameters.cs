using System;

namespace OptionalParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(12));
            Console.WriteLine(Power(10,3));
        }

      


        //static int Power(int x)
        //{
        //    return x * x;
        //}

        static int Power(int x, int y=2)//wordt y niet opgegeven vul dan zelf een 2 in
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
