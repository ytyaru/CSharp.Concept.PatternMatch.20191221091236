using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace Concept.Linq.Lesson0 {
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Lesson0");
            Console.WriteLine("C# 6.0");
            Console.WriteLine($"正方形={Area_6(new Square(5.0))}");
            Console.WriteLine($"正円={Area_6(new Circle(5.0))}");
            Console.WriteLine($"長方形={Area_6(new Rectangle(5.0, 3.0))}");
//            Console.WriteLine($"三角形={Area_6(new Triangle(5.0, 3.0))}");
            Console.WriteLine("C# 7.0");
            Console.WriteLine($"正方形={Area_7(new Square(5.0))}");
            Console.WriteLine($"正円={Area_7(new Circle(5.0))}");
            Console.WriteLine($"長方形={Area_7(new Rectangle(5.0, 3.0))}");
//            Console.WriteLine($"三角形={Area_7(new Triangle(5.0, 3.0))}");

        }
        private double Area_6(object shape)
        {
            if (shape is Square) {
                var s = (Square)shape;
                return s.Side * s.Side; }
            else if (shape is Circle) {
                var c = (Circle)shape;
                return c.Radius * c.Radius * Math.PI; }
            else if (shape is Rectangle) {
                var r = (Rectangle)shape;
                return r.Height * r.Length; }
            // elided
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }
        private double Area_7(object shape)
        {
            if (shape is Square s)
                return s.Side * s.Side;
            else if (shape is Circle c)
                return c.Radius * c.Radius * Math.PI;
            else if (shape is Rectangle r)
                return r.Height * r.Length;
            // elided
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }

    }
}
