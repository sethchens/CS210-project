using System;

namespace Learning05 {
    public class Program {
        static void Main(string[] args) {
            List<Shape> shapeList = new List<Shape>();
            shapeList.Add(new Square("blue", 4));
            shapeList.Add(new Circle("red", 3));
            shapeList.Add(new Rectangle("yellow", 3, 4));

            foreach (Shape shape in shapeList) {
                Console.WriteLine(shape.GetColor());
                Console.WriteLine(shape.GetArea());
            }
        }
    }
}