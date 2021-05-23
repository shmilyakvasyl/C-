using System;

namespace lb6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int counter = 0;
            Console.Write("Введіть n: ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введіть {i + 1}-ше число: ");
                arr[i] = double.Parse(Console.ReadLine());
                sum += arr[i];
                counter++;
            }
            Console.WriteLine($"Середнє арефметичне чисел : {sum / counter}");
            Console.ReadKey();
        }
    }
}