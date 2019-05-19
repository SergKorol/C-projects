using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(10, 20));
            shapes.Add(new Square(30, 40));
            shapes.Add(new Triangle(10, 10));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.DescribeSelf() + " Area: " + shape.Area());
            }

        }
    }
}
