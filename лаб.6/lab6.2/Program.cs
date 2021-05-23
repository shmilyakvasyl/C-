using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int elCount = int.Parse(Console.ReadLine());

            Console.Write("x=");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = a1;
            Console.Write("y=");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double a4 = 0;
            double[] arr = new double[elCount];
            for (int i = 4; i <= arr.Length; i++)
            {
                a4 = a2 + a3 / Math.Pow(2, i - 1) * a1;
                a1 = a2;
                a2 = a3;
                arr[i - 4] = Convert.ToDouble(a4);
            }
            Console.Write("z=");
            double z = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > z)
                {
                    Console.Write("Число {0} бiльше за число {1}\n", arr[i], z);
                }
            }

            Console.ReadLine();
        }
    }
}