using System;
using System.Collections.Generic;

//Практическое задание к уроку 3 по курсу Архитектуры и шаблоны проектирования Брижак Андрей
// Применить шаблон «Фабрика» для создания объектов, описывающих геометрические фигуры (круг,
//квадрат, прямоугольник).



namespace GB_Arch_Patterns_HW03_Brizhak
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            List<IShape> shapes = new List<IShape>()
            {  shapeFactory.CreateInstance("Квадрат"),
                shapeFactory.CreateInstance("Joker"),
                shapeFactory.CreateInstance("Круг"),
                shapeFactory.CreateInstance("Rectangle")
            };

            foreach (IShape shape in shapes) Console.WriteLine($"Shapes: {shape.GetType()}, {shape}");
            Console.ReadKey();

        }
    }
}
