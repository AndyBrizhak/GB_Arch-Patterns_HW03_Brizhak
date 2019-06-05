using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
    public class Сircle : IShape
    {
        public double Radius { get; set; }

        public string Name => "Сircle";

        public  double CalculateArea() => Math.PI*Math.Pow(Radius,2);
        
        public  double CalculatePerimeter() => Math.PI * 2*Radius;
       
    }
}
