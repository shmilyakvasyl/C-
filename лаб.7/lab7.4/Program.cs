using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================================");

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int[] arr = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        arr[j] = matrix[i, j];
                    }
                    Array.Sort(arr);
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = arr[j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}