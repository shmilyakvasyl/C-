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
            Console.Write("Введiть кiлькiсть елементiв:\t");
            int elCount = int.Parse(Console.ReadLine());

            double[] arr1 = new double[elCount];
            double[] arr2 = new double[elCount];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"For x({i}):");
                arr1[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"For y({i}):");
                arr2[i] = double.Parse(Console.ReadLine());
            }
            double[] arr = new double[elCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr1[i] + arr2[i];
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}