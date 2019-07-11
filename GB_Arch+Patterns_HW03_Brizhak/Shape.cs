using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   /// <summary>
   /// Абстрактный клас геометрическая фигура
   /// </summary>
   public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
