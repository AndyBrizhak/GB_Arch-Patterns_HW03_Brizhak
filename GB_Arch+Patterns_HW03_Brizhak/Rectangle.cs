using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   public class Rectangle : Shape
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle()
        {
        }

        public override double CalculateArea() => Width * Height;
        
        public override double CalculatePerimeter() => (Width + Height)*2;
        
    }
}
