using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace Concept.Linq.Lesson1 {
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Lesson1");
            Console.WriteLine("Switch");
            Console.WriteLine($"正方形={Area(new Square(5.0))}");
            Console.WriteLine($"正円={Area(new Circle(5.0))}");
            Console.WriteLine($"長方形={Area(new Rectangle(5.0, 3.0))}");
//            Console.WriteLine($"三角形={Area(new Triangle(5.0, 3.0))}");
            Console.WriteLine("Switch when");
            Console.WriteLine($"正方形={AreaWhen(new Square(5.0))}");
            Console.WriteLine($"正円={AreaWhen(new Circle(5.0))}");
            Console.WriteLine($"長方形={AreaWhen(new Rectangle(5.0, 3.0))}");
            Console.WriteLine($"三角形={AreaWhen(new Triangle(5.0, 3.0))}");

        }
        private double Area(object shape)
        {
            switch (shape)
            {
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Rectangle r:
                    return r.Height * r.Length;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }
        private double AreaWhen(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                case Triangle t when t.Base == 0 || t.Height == 0:
                case Rectangle r when r.Length == 0 || r.Height == 0:
                    return 0;

                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Triangle t:
                    return t.Base * t.Height / 2;
                case Rectangle r:
                    return r.Length * r.Height;

                case null:
                    throw new ArgumentNullException(paramName: nameof(shape), message: "Shape must not be null");
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }
    }
}
