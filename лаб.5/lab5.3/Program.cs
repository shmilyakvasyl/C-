using System;

namespace lb5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double x, e;
            Console.Write("Введіть x: ");
            str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.Write("Введіть точність e: ");
            str = Console.ReadLine();
            e = Convert.ToDouble(str);

            double n = 1;
            double sum = 0;
            double y = Math.Abs(2 + ((1 / 2 * n - 1) * (Math.Pow((x - 1) / (x + 1), 2 * n - 1))));

            while (y > e)
            {
                sum = (2 + ((1 / 2 * n - 1) * (Math.Pow((x - 1) / (x + 1), 2 * n - 1))));
                n += 1;

                if (n == x)
                {
                    break;
                }
            }
            sum += 2;

            Console.WriteLine(sum);






        }
    }
}