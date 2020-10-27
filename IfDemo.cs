using System;

namespace ifDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int getal = rnd.Next();

            if (getal % 2 == 0)
            {
                Console.WriteLine($"{getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"{getal} is een ONeven getal");

            }

            if (getal % 3 == 0)
            {
                Console.WriteLine($"{getal} is deelbaar door 3");
            }
            else if (getal % 3 == 1)
            {
                Console.WriteLine($"{getal} niet deelbaar door drie de rest is 1");
            }
            else
            {
                Console.WriteLine($"{getal} niet deelbaar door drie de rest is 2");

            }

            int rest = getal % 3;
            switch (rest)
            {
                case 0: { Console.WriteLine($"{getal} is deelbaar door 3"); break; }
                case 1: { Console.WriteLine($"{getal} niet deelbaar door drie de rest is 1"); break; }
                case 2: { Console.WriteLine($"{getal} niet deelbaar door drie de rest is 2"); break; }
                default: { Console.WriteLine("vreemde situatie ontstaan die niet afgedekt wordt door de vorige case situaties"); break; }
            }

            //break -> stop met datgene waar je nu mee bezig bent
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                getal = rnd.Next(1, 11);
                Console.WriteLine(getal);
                if (getal == 4)
                {
                    continue;
                   // break;
                }
                Console.WriteLine($"iteratie nummer {i}");

            }
        }
    }
}
