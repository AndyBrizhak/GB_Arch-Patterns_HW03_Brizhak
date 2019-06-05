using System;

namespace GB_Arch_Patterns_HW03_Brizhak
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public string Name => "Квадрат";

        public override double CalculateArea() => Math.Pow(Side, 2);

        public override double CalculatePerimeter() => Side*4;
        
    }
}
