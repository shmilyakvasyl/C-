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
         
            Console.Write("f(3)+f(8)=" + (Func(3) + Func(8)));
            Console.ReadLine();

        }
        static public int Func(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int s = 0;
            int sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                s = f1 + f2;
                f1 = f2;
                f2 = s;
            }
            return s;
        }
    }
}