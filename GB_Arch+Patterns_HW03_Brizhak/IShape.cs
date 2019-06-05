using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   /// <summary>
   /// Интерфейс для описания полей и методов
   /// геометрических форм
   /// </summary>
   public interface IShape
    {
        /// <summary>
        /// Название геометрической формы
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Метод расчета площади
        /// </summary>
        /// <returns></returns>
        double CalculateArea();

        /// <summary>
        /// Метод расчета периметра
        /// </summary>
        /// <returns></returns>
        double CalculatePerimeter();
    }
}
