using System;

namespace MethodDemoOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 5;
            int exp = 3;
            int result = Power(getal);//Method overloading
            Console.WriteLine(result);
            result = Power(getal, exp);//Method overloading
            Console.WriteLine(result);
            getal = 100;
            double exp2 = 0.5;
            double result2 = Power(getal, exp2);
            Console.WriteLine(result2);
        }

        //Signature van de method
        //Naam van de methode
        //aantal parameters
        //type van de parameters

        static int Power(int x)
        {
          return  x* x;
        }

        static int Power(int x,int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        static double Power(int x, double y)
        {
            return Math.Pow(x, y);
        }
        

        }
}
