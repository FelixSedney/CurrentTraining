using System;

namespace OverflowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                long getal = int.MaxValue;
                getal++;
                int intGetal = (int)getal;

                Console.WriteLine(intGetal);
            }
        }
    }
}
