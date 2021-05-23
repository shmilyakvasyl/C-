using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    class Vector2D
    {
        public Tuple<int, int> Value { get; set; }
        public int ScalarProduct { get; set; }

        public int x;
        public int y;

        public void Input()
        {
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            y = int.Parse(Console.ReadLine());
        }
        public Tuple<int, int> Print()
        {
            return Tuple.Create(x, y);
        }
        public static double lenth1;
        public double Lenth()
        {
            lenth1 = Math.Sqrt(x * x + y * y);
            return lenth1;
        }

        public Tuple<double, double> Normalization()
        {
            return Tuple.Create(x / lenth1, y / lenth1);
        }

        public void Compare()
        {
            Console.Write("x:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y:");
            int y2 = int.Parse(Console.ReadLine());
            double lenth2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (lenth1 > lenth2)
            {
                Console.WriteLine("Даний вектор менший за заданий");
            }
            else if (lenth1 < lenth2)
            {
                Console.WriteLine("Даний вектор бiльший за заданий");
            }
            else
            {
                Console.WriteLine("Вектори рiвнi");
            }

        }

        public static Vector2D operator +(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D { Value = Tuple.Create(vector1.x + vector2.x, vector1.y + vector2.y) };
        }

        public static Vector2D operator -(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D { Value = Tuple.Create(vector1.x - vector2.x, vector1.y - vector2.y) };
        }

        public static Vector2D operator *(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D { ScalarProduct = vector1.x * vector2.x + vector1.y * vector2.y };
        }
    }
}