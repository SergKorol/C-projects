using System;
namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override string DescribeSelf()
        {
            return "Rectangle: lengh " + Length + " and " + " width " + Width;
            throw new NotImplementedException();
        }

        public override int Area()
        {
            return Length * Width;
            throw new NotImplementedException();
        }
    }
}
