using System;

namespace lb5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double y;
            for (int i = 1; i < 11;)
            {
                i++;
                y = x;
                x = y + 2 * i;
            }
            Console.WriteLine(x);


        }
    }
}