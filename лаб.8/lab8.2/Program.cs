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
            Console.Write("Введіть кількість елементів:\t");
            int elCount = int.Parse(Console.ReadLine());

            int[] arr1 = new int[elCount];
            for (int i = 0; i < elCount; i++)
            {
                Console.Write($"For a({i}):");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[elCount];
            for (int i = 0; i < elCount; i++)
            {
                Console.Write($"For b({i}):");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[elCount];
            for (int i = 0; i < elCount; i++)
            {
                Console.Write($"For c({i}):");
                arr3[i] = int.Parse(Console.ReadLine());
            }
            (int, int) sp = Function(elCount, arr1, arr2, arr3);
            var (sp1, sp2) = sp;
            int result = 2 * sp1 - 3 * sp2;
            Console.Write(result);
            Console.ReadLine();
        }
        public static (int, int) Function(int elCount, int[] arr1, int[] arr2, int[] arr3)
        {
            int sp1 = 0;
            int sp2 = 0;
            for (int i = 0; i < elCount; i++)
            {
                sp1 += arr1[i] * arr2[i];
            }
            for (int i = 0; i < elCount; i++)
            {
                sp2 += arr1[i] * arr3[i];
            }
            var turple = (sp1, sp2);
            return turple;
        }

    }
}