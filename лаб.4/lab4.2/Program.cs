using System;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a, b;
            Console.Write("Введіть перше число: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.Write("Введіть друге число: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            if (a >= 1 && a <= 2 && b >= 1 && b <= 2 || a > 3 && a < 7 && b > 3 && b < 7)

            {
                Console.WriteLine("Числа входять у діапазон");
            }
            else
            {
                Console.WriteLine("Числа НЕ входять у діапозон");
            }
        }
    }
}