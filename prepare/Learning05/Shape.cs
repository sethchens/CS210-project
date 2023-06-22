using System;

namespace Learning05 {
    public abstract class Shape {
        private string _color;

        public string GetColor() {
            return _color;
        }
        private void SetColor(string color) {
            _color = color;
        }
        public abstract double GetArea();

        public Shape(string color) {
            SetColor(color);
        }
    }
}