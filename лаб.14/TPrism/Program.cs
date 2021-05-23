using System;


namespace Test
{
    public class TPrism
    {
        public uint height { get; set; }
        public uint number_of_sides { get; set; }
        public uint length_of_side { get; set; }

        public double Square()
        {
            double square_of_basis;
            double square_of_sides;
            if (number_of_sides == 3)
            {
                square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            }
            else if (number_of_sides == 4)
            {
                square_of_basis = length_of_side * length_of_side;
            }
            else if (number_of_sides >= 5)
            {
                square_of_basis = (number_of_sides * length_of_side * length_of_side) / (4 * Math.Tan(180 / number_of_sides));
            }
            else
            {
                square_of_basis = 0;
            }

            square_of_sides = number_of_sides * length_of_side * height;
            double full_square = 2 * square_of_basis + square_of_sides;
            return full_square;
        }

        public double volume;
        public double Volume()
        {
            double square_of_basis;
            if (number_of_sides == 3)
            {
                square_of_basis = Math.Sqrt(3) / 4 * length_of_side * length_of_side;
            }
            else if (number_of_sides == 4)
            {
                square_of_basis = length_of_side * length_of_side;
            }
            else if (number_of_sides >= 5)
            {
                square_of_basis = (number_of_sides * length_of_side * length_of_side) / (4 * Math.Tan(180 / number_of_sides));
            }
            else
            {
                square_of_basis = 0;
            }

            double volume = square_of_basis * height;
            return volume;
        }

    }
}