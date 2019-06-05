namespace GB_Arch_Patterns_HW03_Brizhak
{
    /// <summary>
    /// Геометрическая форма - прямоугольник
    /// </summary>
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
