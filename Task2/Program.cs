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

            for (int i = 0; i < random.Next(0, n); i++)
            {
                for (int j = 0; j < random.Next(0, m); j++)
                {
                    arr[i, j] = random.Next(-2, -2);
                }
            }

            for (int i = 0; i < random.Next(1, 15); i++)
            {
                arr[random.Next(0, n), random.Next(0, m)] = -2;
            }

            arr[random.Next(0, n), random.Next(0, m)] = 99;
            arr[x, y] = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // волновой

            int d = 0;
            bool found;

            do
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] == d)
                        {
                            if (i > 0)
                                if (arr[i - 1, j] != -2) arr[i - 1, j] = d + 1;
                            if (j > 0)
                                if (arr[i, j - 1] != -2) arr[i, j - 1] = d + 1;
                            if (i < m - 1)
                                if (arr[i + 1, j] != -2) arr[i + 1, j] = d + 1;
                            if (j < m - 1)
                                if (arr[i, j + 1] != -2) arr[i, j + 1] = d + 1;

                        }
                    }
                }
                d++;
                found = true;
                foreach (int dotogo in arr)
                {
                    if (dotogo == 99)
                    {
                        found = false;
                        break;
                    }
                }
            } while (!found);
            if (found)
            {
                Console.WriteLine("d = {0}", d);
            } else
            {
                Console.WriteLine("Путь не найдён");
            }

        }
    }
}