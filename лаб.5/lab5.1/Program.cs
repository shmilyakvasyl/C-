using System;

namespace lb5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int n, i;
            double a, sum;
            Console.Write("Введіть n: ");
            str = Console.ReadLine();
            n = Convert.ToInt32(str);
            Console.Write("Введіть a: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            sum = a;
            i = 1;
            while (i < n - 1)
            {
                i += i;
                sum = sum * (a + n);
            }
            Console.WriteLine(sum);

        }
    }
}