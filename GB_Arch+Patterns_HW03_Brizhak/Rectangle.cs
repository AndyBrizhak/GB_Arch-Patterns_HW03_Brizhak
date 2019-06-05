using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name => "Rectangle";

        public Rectangle()
        {
        }

        public  double CalculateArea() => Width * Height;
        
        public  double CalculatePerimeter() => (Width + Height)*2;
        
    }
}
