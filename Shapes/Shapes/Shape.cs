using System;
namespace Shapes
{
    public abstract class Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }


        public abstract string DescribeSelf();
        public abstract int Area();

       
    }
}
