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
    }

    
}
