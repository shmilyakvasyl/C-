using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int[] arr = new int[n * m];

            int x = 1;
            int y = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i * j % 2 == 0)
                    {
                        for (int k = 0; k < n + 1; k++)
                        {
                            x *= k;
                            matrix[i, j] = x;
                        }
                    }
                    else
                    {
                        for (int t = 0; t < m + 1; t++)
                        {
                            y += t;
                            matrix[i, j] = y;
                        }
                    }

                    Console.WriteLine(matrix[i, j]);

                }
            }
            Console.WriteLine("=========================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i] = matrix[i, j];
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}