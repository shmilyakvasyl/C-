using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector = new Vector2D();
            Vector2D vector1 = new Vector2D { x = 5, y = 4 };
            Vector2D vector2 = new Vector2D { x = 5, y = 4 };
            Vector2D addition = vector1 + vector2;
            Vector2D subtraction = vector1 - vector2;
            Vector2D scalarproduction = vector1 * vector2;
            vector.Input();
            Console.WriteLine(vector.Print());
            Console.WriteLine(vector.Lenth());
            Console.WriteLine(vector.Normalization());
            vector.Compare();
            Console.WriteLine(addition.Value);
            Console.WriteLine(subtraction.Value);
            Console.WriteLine(scalarproduction.ScalarProduct);

            Vector3D vector3d = new Vector3D();
            Vector3D vector3d1 = new Vector3D { x = 5, y = 4, z = 1 };
            Vector3D vector3d2 = new Vector3D { x = 5, y = 4, z = 1 };
            Vector3D addition2 = vector3d1 + vector3d2;
            Vector3D subtraction2 = vector3d1 - vector3d2;
            Vector3D scalarproduction2 = vector3d1 * vector3d2;
            vector3d.Input();
            Console.WriteLine(vector3d.Print());
            Console.WriteLine(vector3d.Lenth());
            Console.WriteLine(vector3d.Normalization());
            vector3d.Compare();
            Console.WriteLine(addition2.ValuE);
            Console.WriteLine(subtraction2.ValuE);
            Console.WriteLine(scalarproduction2.ScalarProduct);


            Console.ReadLine();
        }

    }

}