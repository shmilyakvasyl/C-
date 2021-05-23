using System;


namespace Task1
{
    public class Vector3D : Vector2D
    {
        public Tuple<int, int, int> ValuE { get; set; }
        public int z;

        public void Input()
        {
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            y = int.Parse(Console.ReadLine());
            Console.Write("z=");
            z = int.Parse(Console.ReadLine());
        }
        public Tuple<int, int, int> Print()
        {
            return Tuple.Create(x, y, z);
        }
        public static double lenth1;
        public double Lenth()
        {
            lenth1 = Math.Sqrt(x * x + y * y + z * z);
            return lenth1;
        }

        public Tuple<double, double, double> Normalization()
        {
            return Tuple.Create(x / lenth1, y / lenth1, z / lenth1);
        }

        public void Compare()
        {
            Console.Write("x:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y:");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("z:");
            int z2 = int.Parse(Console.ReadLine());
            double lenth2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);

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

        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D { ValuE = Tuple.Create(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z) };
        }

        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D { ValuE = Tuple.Create(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z) };
        }

        public static Vector3D operator *(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D { ScalarProduct = vector1.x * vector2.x + vector1.y * vector2.y + vector1.z + vector2.z };
        }
    }
}