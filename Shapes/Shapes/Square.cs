using System;
namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(int l, int w)
            :base(l, w)
        {
        }
        public override string DescribeSelf()
        {
            return "Square: lengh " + Length + " and " + " width " + Width;
            throw new NotImplementedException();
        }
    }
}
