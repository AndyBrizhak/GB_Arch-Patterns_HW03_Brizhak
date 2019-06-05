namespace GB_Arch_Patterns_HW03_Brizhak
{
    /// <summary>
    /// Неизвестная геометрическая форма
    /// </summary>
    public class UnknownShape : IShape
    {
        public string Name => "Неизвестная форма";

        public double CalculateArea() => 0;
        
        public double CalculatePerimeter() => 0;
   }
}
