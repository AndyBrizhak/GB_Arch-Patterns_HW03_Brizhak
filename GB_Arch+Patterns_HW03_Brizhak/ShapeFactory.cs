using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace GB_Arch_Patterns_HW03_Brizhak
{
   public class ShapeFactory
    {
        Dictionary<string, Type> shapes;

        public ShapeFactory() => LoadTypes();

        private void LoadTypes()
        {
            shapes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            //foreach (var item in typesInThisAssembly) Console.WriteLine($"---- {item.Name}");

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IShape).ToString()) != null)
                {
                    shapes.Add(type.Name, type);
                }
            }
        }

        public IShape CreateInstance(string name)
        {
            Type t = GetTypeToCreate(name);

            return t == null ?
                new UnknownShape() :
                Activator.CreateInstance(t) as IShape;
        }

        private Type GetTypeToCreate(string shapeType)
        {
            foreach (var shape in shapes)
            {
                if (shape.Key.Contains(shapeType))
                {
                    return shapes[shape.Key];
                }
            }
            return null;
        }
    }

    
}
