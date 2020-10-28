using System;

namespace VaraiableParameterList
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 12;
            int getal2 = 34;
            double result = Average(getal1, getal2);
            Console.WriteLine(result);
            //int[] getallen = { 12, 34, 60 };
            result = Average(12, 34, 60,80);
            //result = Average(getallen);
            Console.WriteLine(result);
        }

        //private static double Average(int v1, int v2, int v3)
        //{
        //    return (v1 + v2 + v3) / 3;
        //}

        private static double Average(params int[] argumenten)
        {
            double sum = 0;
            foreach (var item in argumenten)
            {
                sum += item;
            }
            return sum / argumenten.Length;
        }

        private static double Average(int getal1, int getal2)
        {
            return (getal1 + getal2) / 2;
        }
    }
}
