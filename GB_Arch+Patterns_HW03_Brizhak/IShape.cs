using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   public interface IShape
    {
        string Name { get; }
        double CalculateArea();
        double CalculatePerimeter();
    }
}
