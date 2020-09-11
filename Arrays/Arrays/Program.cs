using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = rand.Next(1, 10);
            int m = rand.Next(20, 50);
            int[,] mas = new int[n, m];

            Console.WriteLine("Array :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next(0,9);
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine("Sorted array :");

            for (int i = 0; i < mas.GetLength(0); i++)
               
                for (int j = 0; j < mas.GetLength(1); j++)
                    for (int k = 0; k < mas.GetLength(1); k++)
                    {
                        if (mas[i, k] <= mas[i, j]) continue;
                        int temp = mas[i, k];
                        mas[i, k] = mas[i, j];
                        mas[i, j] = temp;
                    }

            for (int i = 0; i < mas.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j]);

                }
            Console.WriteLine("\t");


        }
    }
}
