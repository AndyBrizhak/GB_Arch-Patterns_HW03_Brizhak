using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   /// <summary>
   /// Неизвестная геометрическая форма
   /// </summary>
   public class UnknownShape : IShape
    {
        public string Name => "UnknownShape";

        public double CalculateArea() => 0;
        
        public double CalculatePerimeter() => 0;
   }
}
