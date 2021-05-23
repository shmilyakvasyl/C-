using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2

{
    class Array
    {
        private double[] array;

        private double[] ArraY
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }

        public void IntroductionOfElements()
        {
            Console.WriteLine("How many elements u want?");
            int n = int.Parse(Console.ReadLine());
            array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter a {i + 1} element: ");
                double el = Convert.ToDouble(Console.ReadLine());
                array[i] = el;
            }

        }

        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }

        public double MaxOfElements()
        {
            double max = int.MinValue;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public double MinOfElements()
        {
            double min = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }

}