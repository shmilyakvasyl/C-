using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            Random rnd = new Random();
            int s = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"matrix[{0}]:", i);
                    int n = int.Parse(Console.ReadLine());
                    arr[i, j] = n;
                    Console.Write(arr[i, j] + "\t");
                    s = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
                }
                Console.WriteLine();
            }
            Console.Write($"Детермiнант={0}", s);
            Console.ReadLine();
        }
    }
}