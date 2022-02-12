using System;

namespace labwork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, m = 0, x = 0, y = 0;
            Random random = new Random();

            Console.Write("Количество строк -> "); n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов -> "); m = Convert.ToInt32(Console.ReadLine());
            Console.Write("x -> "); x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y -> "); y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] arr = new int[n, m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = -1;
                }
            }

            for (int i = 0; i < random.Next(n); i++)
            {
                for (int j = 0; j < random.Next(m); j++)
                {
                    arr[i, j] = random.Next(-2, -2);
                }
            }

            for (int i = 0; i < random.Next(1, 15); i++)
            {
                arr[random.Next(0, n), random.Next(m)] = -2;
            }

            arr[random.Next(0, n), random.Next(m)] = 99;
            arr[x - 1, y - 1] = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}