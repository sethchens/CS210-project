using System;

namespace Learning05{
    public class Circle : Shape{
        private double _radius;

        public override double GetArea() {
            return _radius * _radius * 3.14159;
        }

        public Circle(string color, double radius) : base(color){
            _radius = radius;
        }
    }
}