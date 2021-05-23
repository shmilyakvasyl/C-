using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TMoney
    {
        public double Value { get { return value; } }

        public const double value = 28.01;

        public string Add()
        {
            Console.Write("UAH1 add:");
            double UAH1 = double.Parse(Console.ReadLine());
            Console.Write("to UAH2:");
            double UAH2 = double.Parse(Console.ReadLine());
            double USD1 = UAH1 / value;
            double USD2 = UAH2 / value;
            double sum = USD1 + USD2;
            if (UAH1 > 0 & UAH2 > 0)
            {
                return $"{sum}$";
            }
            else
            {
                return "Should be positive!";
            }
        }

        public string Sub()
        {
            Console.Write("UAH1 sub:");
            double UAH1 = double.Parse(Console.ReadLine());
            Console.Write("from UAH2:");
            double UAH2 = double.Parse(Console.ReadLine());
            double USD1 = UAH1 / value;
            double USD2 = UAH2 / value;
            double subtraction = USD2 - USD1;
            if (UAH1 > 0 & UAH2 > 0)
            {
                return $"{subtraction}$";
            }
            else
            {
                return "Should be positive!";
            }
        }

        public double CourseGain()
        {
            return value + 100;
        }
    }

}