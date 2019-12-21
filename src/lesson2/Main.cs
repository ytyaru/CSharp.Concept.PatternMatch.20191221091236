using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace Concept.Linq.Lesson2 {
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Lesson2");
            var c = CreateShape("circle");
            var s = CreateShape("circle");
            var lc = CreateShape("large-circle");
//            var n = CreateShape("");
//            var abc = CreateShape("abc");

            Console.WriteLine($"c={CalcArea(c)}");
            Console.WriteLine($"s={CalcArea(s)}");
            Console.WriteLine($"lc={CalcArea(lc)}");
//            Console.WriteLine($"n={CalcArea(n)}");
//            Console.WriteLine($"abc={CalcArea(abc)}");
        }
        private object CreateShape(string shapeDescription)
        {
            switch (shapeDescription)
            {
                case "circle":
                    return new Circle(2);

                case "square":
                    return new Square(4);
                
                case "large-circle":
                    return new Circle(12);

                case var o when (o?.Trim().Length ?? 0) == 0:
                    // white space
                    return null;
                default:
                    return "invalid shape description";
            }            
        }
        private double CalcArea(object shape)
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
