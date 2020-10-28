using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //vullen
            int[] intArr = new int[10];//10 is het aantal cellen. De hoogste index is hier 9
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(1, 100);
            }
            //afdrukken
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{intArr[i]}\t");
            //}
            foreach (var item in intArr)//gebruiken om een collectie te doorlopen.PAS OP is ReadOnly
            {
                Console.Write($"{item}\t");
            }
          
            //Console.WriteLine(intArr[10]);//Exception OutOfRange
        }
    }
}
