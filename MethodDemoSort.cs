using System;

namespace MethodDemoSort
{
    class Program
    { 
        static int[] intArr = new int[10];
        static void Main(string[] args)
        {
            //programma sorteert getallen in een array
            //drukt ongesorteerde en gesorteerde array af

           

            VulArray();
            DrukArrayAf();
            SorteerArray();
            DrukArrayAf();

        }

        private static void SorteerArray()
        {
            for (int j = 0; j < intArr.Length-1; j++)
            {
                for (int i = 0; i < intArr.Length - 1; i++)
                {
                    if (intArr[i] > intArr[i + 1])
                    {
                        //int temp = intArr[i];
                        //intArr[i] = intArr[i + 1];
                        //intArr[i + 1] = temp;
                        Swap(ref intArr[i],ref intArr[i + 1]);
                    }
                }  
            }
        }

        static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static void DrukArrayAf()
        {
            foreach (var item in intArr)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void VulArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(1, 200);
            }
            
        }
    }
}
