using System;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;

            Random rnd = new Random();
           
            for (int k = 0; k < 3; k++)
            {
                getal = rnd.Next(10,25);
                Console.WriteLine(getal);
            }

            double som = 1200;
            Console.WriteLine(som/23);
        }
    }
}
