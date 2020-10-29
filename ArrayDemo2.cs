using System;

namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[15];//1 dimensionale verzameling van integers. 15 elementen. hoogste index is 14
            int[] intArr2 = { 12, 34, 56, 78, 90 };//1 dimensionale verzameling van int. 5 elementen.
            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine(intArr2[i]);
            }

            foreach (var item in intArr2)
            {
                Console.WriteLine(item);
            }
            // intArr2.GetLength()

            int[,] grid = new int[3, 4];
            Random rnd = new Random();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = rnd.Next(1, 100);
                }
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write($"{grid[i, j]}\t");
                }
                Console.WriteLine();
            }

            int[,] grid2 = { { 1, 2, 3 }, { 4, 5, 6 } };
        }
    }
}
