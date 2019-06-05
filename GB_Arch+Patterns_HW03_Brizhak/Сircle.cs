using System;

namespace GB_Arch_Patterns_HW03_Brizhak
{
    /// <summary>
    /// Геометрическая форма - круг
    /// </summary>
    public class Сircle : IShape
    {
        public double Radius { get; set; }

        public string Name => "Круг";

        public  double CalculateArea() => Math.PI*Math.Pow(Radius,2);
        
        public  double CalculatePerimeter() => Math.PI * 2*Radius;
       
    }
}
