using System;
namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public override string DescribeSelf()
        {
            return "Triangle: lengh " + Length + " and " + " width " + Width;
            throw new NotImplementedException();
        }

        public override int Area()
        {
            return Length * Width / 2;
            throw new NotImplementedException();
        }
    }
}
