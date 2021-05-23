using System;

namespace lb4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double A, C, N;
            Console.Write("Введіть А: ");
            str = Console.ReadLine();
            A = Convert.ToInt32(str);
            Console.Write("Введіть C: ");
            str = Console.ReadLine();
            C = Convert.ToInt32(str);
            Console.Write("Введіть N: ");
            str = Console.ReadLine();
            N = Convert.ToInt32(str);
            if (A == C && C == N)
            {
                double y = Math.Cos(A + C + N);
                Console.WriteLine("y={0}", y);
            }

            else if (A < C && C == N)
            {
                double y = Math.Cos(A * C * N);
                Console.WriteLine("y={0}", y);
            }
            else if (A < C && C < N)
            {
                double y = Math.Cos((A + C) * N);
                Console.WriteLine("y={0}", y);
            }
            else
            {
                double y = 0;
                Console.WriteLine("y={0}", y);
            }
        }
    }
}