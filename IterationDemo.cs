using System;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)//gebruiken als het aantal iteraties van te voren bekend is.
            {
                Console.WriteLine($"{i} x 4 = {i * 4}");
            }
            //Console.WriteLine(i);

            //Console.WriteLine("please enter your password");

            //string pwd = Console.ReadLine();
            //voorwaarde vooraf
            //while (pwd != "sesamopen")//gebruiken als aantal iteraties niet bekend is en de code 0 of meerdere keren doorlopen moet worden

            //{
            //    Console.WriteLine("please enter your password");
            //    pwd = Console.ReadLine();
            //}

            string pwd;
            //voorwaarde achteraf
            do//aantal iteraties is niet van te voren bekend, maar is minimaal 1
            {
                Console.WriteLine("please enter your password");
                pwd = Console.ReadLine();
            } while (pwd != "sesamopen");

            int y = 1;

            while (y < 11)
            {
                Console.WriteLine($"{y} x 4 = {y * 4}");
                y++;
            }

        }
    }
}
