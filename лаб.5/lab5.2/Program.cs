using System;

namespace lb5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int n, i;
            Console.Write("Введіть n: ");
            str = Console.ReadLine();
            n = Convert.ToInt32(str);
            i = 0;
            while (n != 0)
            {
                n = n / 10;
                i += 1;

            }
            Console.WriteLine("i={0}", i);
        }
    }
}