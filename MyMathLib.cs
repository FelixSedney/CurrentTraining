using System;

namespace MyMathLibrary
{
    public class MyMath
    {
        public static int Power(int x, int y = 2)
        {
            int temp = 1;
            for (int i = 0; i < y; i++)
            {
                temp *= x;
            }
            return temp;
        }

        public static double Power(int x, double y )
        {
            return Math.Pow(x,y);
          }

        public static double Average(params int[] values)
        {
            int temp = 0;
            foreach (var item in values)
            {
                temp += item;
            }
            return DivideIntReturnDouble( temp, values.Length);
        }

       private static double DivideIntReturnDouble(int x,int y)
        {
            return (double)x / (double)y;
        }



    }
}
