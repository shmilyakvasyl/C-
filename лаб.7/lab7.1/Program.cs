using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                    Console.Write(arr[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int s = 0;
            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    if (arr[i, j] < 0)
                    {
                        s += arr[i, j];
                    }
                }
            }

            Console.Write(s);
            Console.ReadLine();
        }
    }
}