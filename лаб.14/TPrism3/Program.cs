using System;


namespace Test
{
    public class TPrism3 : TPrism
    {
        public new int number_of_sides = 3;

        public new double Square()
        {
            double square_of_basis;
            double square_of_sides;

            square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            square_of_sides = number_of_sides * length_of_side * height;
            double full_square = 2 * square_of_basis + square_of_sides;
            return full_square;
        }

        public new double Volume()
        {
            double square_of_basis;

            square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            double volume = square_of_basis * height;
            return volume;
        }
    }
}