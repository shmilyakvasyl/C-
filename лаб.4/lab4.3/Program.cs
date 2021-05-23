using System;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double x1, x2, x3, y1, y2, y3;
            Console.Write("Введіть першу координату сторони А: ");
            str = Console.ReadLine();
            x1 = Convert.ToInt32(str);
            Console.Write("Введіть другу координату сторони А: ");
            str = Console.ReadLine();
            y1 = Convert.ToInt32(str);
            Console.Write("Введіть першу координату сторони B: ");
            str = Console.ReadLine();
            x2 = Convert.ToInt32(str);
            Console.Write("Введіть другу координату сторони B: ");
            str = Console.ReadLine();
            y2 = Convert.ToInt32(str);
            Console.Write("Введіть першу координату сторони C: ");
            str = Console.ReadLine();
            x3 = Convert.ToInt32(str);
            Console.Write("Введіть другу координату сторони C: ");
            str = Console.ReadLine();
            y3 = Convert.ToInt32(str);

            double AB = Math.Pow(Math.Pow((x2 - x1) + (y2 - y1), 2), 1 / 2);
            double BC = Math.Pow(Math.Pow((x3 - x2) + (y3 - y2), 2), 1 / 2);
            double CA = Math.Pow(Math.Pow((x1 - x3) + (y1 - y3), 2), 1 / 2);



            if ((AB + BC) > CA && (BC + CA) > AB && (CA + AB) > BC)
            {
                Console.WriteLine("Трикутник є вродженим ");
            }
            else
            {
                Console.WriteLine("Трикутник НЕ є вродженим ");
            }
        }
    }
}
