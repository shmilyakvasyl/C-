using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            int max = 0;
            int k = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            while (k < 2)
            {
                max = (from int x in matrix select x).Max();
                k = 0;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == max)
                        {

                            matrix[i, j] = int.MinValue;
                            k++;
                        }
                    }
            }
            Console.WriteLine("=========================");
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}