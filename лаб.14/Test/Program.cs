using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TPrism Prism = new TPrism();
            Console.Write("height of prism(Prism with 3 sides)=");
            uint h1 = uint.Parse(Console.ReadLine());
            Console.Write("length of side(Prism with 3 sides)=");
            uint side1 = uint.Parse(Console.ReadLine());
            TPrism prism1 = new TPrism3 { height = h1, length_of_side = side1 };

            Console.Write("height of prism(Prism with 4 sides)=");
            uint h2 = uint.Parse(Console.ReadLine());
            Console.Write("length of side(Prism with 4 sides)=");
            uint side2 = uint.Parse(Console.ReadLine());
            TPrism prism2 = new TPrism4 { height = h2, length_of_side = side2 };

            Console.Write("m=");
            uint m = uint.Parse(Console.ReadLine());

            int k = 50;
            double volume = 0;
            double h = Prism.height;
            for (int i = 0; i < m; i++)
            {
                TPrism prism = new TPrism3 { volume = k };
                k += 5;
                volume += prism.volume;
            }

            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                TPrism prismm = new TPrism4 { volume = k / h };
                k += 5;
                sum += prismm.volume;
            }

            Console.ReadLine();
        }
    }
}